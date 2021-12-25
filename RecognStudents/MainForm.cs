using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.IO.Ports;

namespace AForge.WindowsForms
{
    delegate void FormUpdateDelegate();

    public partial class MainForm : Form
    {
        WindowsForms.SamplesSet trainData = AForge.WindowsForms.BaseNetwork.PrepareSampleSet();
        AForge.WindowsForms.SamplesSet testData = AForge.WindowsForms.BaseNetwork.PrepareTestSet();
        
        AForge.WindowsForms.BaseNetwork SelectedNet;
       // AForge.WindowsForms.AccordNet AccNet;
        AForge.WindowsForms.StudentNetwork StudNet;

        /// <summary>
        /// Класс, реализующий всю логику работы
        /// </summary>
        private Controller controller = null;

        /// <summary>
        /// Событие для синхронизации таймера
        /// </summary>
        private AutoResetEvent evnt = new AutoResetEvent(false);
                
        /// <summary>
        /// Список устройств для снятия видео (веб-камер)
        /// </summary>
        private FilterInfoCollection videoDevicesList;
        
        /// <summary>
        /// Выбранное устройство для видео
        /// </summary>
        private IVideoSource videoSource;
        
        /// <summary>
        /// Таймер для измерения производительности (времени на обработку кадра)
        /// </summary>
        private Stopwatch sw = new Stopwatch();
        
        /// <summary>
        /// Таймер для обновления объектов интерфейса
        /// </summary>
        System.Threading.Timer updateTmr;

        /// <summary>
        /// Функция обновления формы, тут же происходит анализ текущего этапа, и при необходимости переключение на следующий
        /// Вызывается автоматически - это плохо, надо по делегатам вообще-то
        /// </summary>
        private void UpdateFormFields()
        { 
            //  Проверяем, вызвана ли функция из потока главной формы. Если нет - вызов через Invoke
            //  для синхронизации, и выход
            if (statusLabel.InvokeRequired)
            {
                this.Invoke(new FormUpdateDelegate(UpdateFormFields));
                return;
            }

            sw.Stop();
            ticksLabel.Text = "Тики : " + sw.Elapsed.ToString();
            originalImageBox.Image = controller.GetOriginalImage();
            processedImgBox.Image = controller.GetProcessedImage();
            int cw = processedImgBox.Image.Width, ch = processedImgBox.Image.Height;
            Bitmap b = new Bitmap(processedImgBox.Image);
            var arr = new double[28 * 28];//массив для заполнения
            for (int i = 0; i < 28; ++i)//делим изображение на куски считаем средний цвет
                for (int j = 0; j < 28; ++j)
                {
                    double pix = 0.0;//среднее арифметическое
                    for (int si = 0; si < cw / 28; ++si)
                        for (int sj = 0; sj < ch / 28; ++sj)
                        {
                            Color c = b.GetPixel(i * (cw / 28) + si, j * (ch / 28) + sj);
                            pix += c.R;
                        }
                    pix /= (cw / 28) * (ch / 28);
                    pix /= 255;
                    arr[i * 28 + j] = pix; //среднюю серость
                }

            var rb = new Bitmap(112, 112);//для примера
            for (int i = 0; i < 112; ++i)
                for (int j = 0; j < 112; ++j)
                {
                    int col = (int)(arr[(i / 4) * 28 + (j / 4)] * 255);
                    rb.SetPixel(i, j, Color.FromArgb(col, col, col));
                }
            ResultPB.Image = rb;

            AForge.WindowsForms.Sample sample = new AForge.WindowsForms.Sample(arr, 10);
            ResultDigitLabel.Text = "Result: " + SelectedNet.Predict(sample);

            var sb = new Bitmap(112, 112);//пример из выборки (жирная 3)
            for (int i = 0; i < 112; ++i)
                for (int j = 0; j < 112; ++j)
                {
                    int col = (int)(trainData.samples.ElementAt(12).input[(i / 4) * 28 + (j / 4)] * 255);
                    sb.SetPixel(i, j, Color.FromArgb(col, col, col));
                }
            SamplePB.Image = sb;
        }

        /// <summary>
        /// Обёртка для обновления формы - перерисовки картинок, изменения состояния и прочего
        /// </summary>
        /// <param name="StateInfo"></param>
        public void Tick(object StateInfo)
        {
            UpdateFormFields();
            return;
        }

        public void UpdateLearningInfo(double progress, double error, TimeSpan elapsedTime)
        {

            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new AForge.WindowsForms.TrainProgressHandler(UpdateLearningInfo), progress, error, elapsedTime);
                return;
            }

            int progressPercent = (int)System.Math.Round(progress * 100);
            progressPercent = System.Math.Min(100, System.Math.Max(0, progressPercent));
            ResultDigitLabel.Text = "Время : " + elapsedTime.Duration().ToString(@"hh\:mm\:ss\:ff");
            ResultDigitLabel.Refresh();
            TestLable.Text = "Error: " + error;
            TestLable.Refresh();
            progressBar1.Value = progressPercent;
        }

            public MainForm()
        {
            InitializeComponent();
            // Список камер получаем
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                cmbVideoSource.Items.Add(videoDevice.Name);
            }
            if (cmbVideoSource.Items.Count > 0)
            {
                cmbVideoSource.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("А нет у вас камеры!", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            controller = new Controller(new FormUpdateDelegate(UpdateFormFields));
//            updateTmr = new System.Threading.Timer(Tick, evnt, 500, 100);
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //  Время засекаем
            sw.Restart();

            //  Отправляем изображение на обработку, и выводим оригинал (с раскраской) и разрезанные изображения
            if(controller.Ready)
                
                #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                controller.ProcessImage((Bitmap)eventArgs.Frame.Clone());
                #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

                //  Это выкинуть в отдельный поток!
                //  И отдать делегат? Или просто проверять значение переменной?
                //  Тут хрень какая-то

                //currentState = Stage.Thinking;
                //sage.solveState(processor.currentDeskState, 16, 7);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                var vcd = new VideoCaptureDevice(videoDevicesList[cmbVideoSource.SelectedIndex].MonikerString);
                vcd.VideoResolution = vcd.VideoCapabilities[resolutionsBox.SelectedIndex];
                Debug.WriteLine(vcd.VideoCapabilities[1].FrameSize.ToString());
                Debug.WriteLine(resolutionsBox.SelectedIndex);
                videoSource = vcd;
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
                StartButton.Text = "Стоп";
                controlPanel.Enabled = true;
                cmbVideoSource.Enabled = false;
            }
            else
            {
                videoSource.SignalToStop();
                if (videoSource != null && videoSource.IsRunning && originalImageBox.Image != null)
                {
                    originalImageBox.Image.Dispose();
                }
                videoSource = null;
                StartButton.Text = "Старт";
                controlPanel.Enabled = false;
                cmbVideoSource.Enabled = true;
            }
        }

        private void tresholdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            controller.settings.threshold = (byte)tresholdTrackBar.Value;
            controller.settings.differenceLim = (float)tresholdTrackBar.Value/tresholdTrackBar.Maximum;
        }

        private void borderTrackBar_ValueChanged(object sender, EventArgs e)
        {
            controller.settings.border = borderTrackBar.Value;
        }

        private void marginTrackBar_ValueChanged(object sender, EventArgs e)
        {
            controller.settings.margin = marginTrackBar.Value;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateTmr != null)
                updateTmr.Dispose();

            //  Как-то надо ещё робота подождать, если он работает

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W: controller.settings.decTop(); Debug.WriteLine("Up!"); break;
                case Keys.S: controller.settings.incTop(); Debug.WriteLine("Down!"); break;
                case Keys.A: controller.settings.decLeft(); Debug.WriteLine("Left!"); break;
                case Keys.D: controller.settings.incLeft(); Debug.WriteLine("Right!"); break;
                case Keys.Q: controller.settings.border++; Debug.WriteLine("Plus!"); break;
                case Keys.E: controller.settings.border--; Debug.WriteLine("Minus!"); break;
            }
        }

        private void cmbVideoSource_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var vcd = new VideoCaptureDevice(videoDevicesList[cmbVideoSource.SelectedIndex].MonikerString);
            resolutionsBox.Items.Clear();
            for (int i = 0; i < vcd.VideoCapabilities.Length; i++)
                resolutionsBox.Items.Add(vcd.VideoCapabilities[i].FrameSize.ToString());
            resolutionsBox.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            controller.settings.processImg = checkBox1.Checked;
        }

        private void AccordRB_CheckedChanged(object sender, EventArgs e)
        {
            //if (AccordRB.Checked)
               // SelectedNet = AccNet; 
        }

        private void StudentRB_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentRB.Checked)
                SelectedNet = StudNet;
        }

        private void CreateNetButton_Click(object sender, EventArgs e)
        {
            int[] structure = NetStructureTB.Text.Split(';').Select(x => int.Parse(x)).ToArray();
            //if (AccordRB.Checked)
             //   SelectedNet = new AForge.WindowsForms.AccordNet(structure);
            if (StudentRB.Checked)
                SelectedNet = new AForge.WindowsForms.StudentNetwork(structure);
            SelectedNet.TrainProgress += UpdateLearningInfo;
        }

        private void StudyNetButton_Click(object sender, EventArgs e)//кнопка перосоздать и обучить
        {
            ResultDigitLabel.Text = "Studying...";
            ResultDigitLabel.Refresh();
            AForge.WindowsForms.SamplesSet set = new AForge.WindowsForms.SamplesSet();
            set.samples = trainData.samples.Take((int)TraningSetLength.Value).ToList();
            SelectedNet.TrainOnDataSet(set, 10, 1, false);
            ResultDigitLabel.Text = "Finished!";
            ResultDigitLabel.Refresh();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestLable.Text = "Test: " + testData.TestNeuralNetwork(SelectedNet) * 100 + " %";
        }
    }
}
