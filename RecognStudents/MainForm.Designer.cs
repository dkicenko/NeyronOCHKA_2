namespace AForge.WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbVideoSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TestLable = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.resolutionsBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ticksLabel = new System.Windows.Forms.Label();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.processedImgBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StudyNetButton = new System.Windows.Forms.Button();
            this.CreateNetButton = new System.Windows.Forms.Button();
            this.NetStructureTB = new System.Windows.Forms.TextBox();
            this.TraningSetLength = new System.Windows.Forms.NumericUpDown();
            this.StudentRB = new System.Windows.Forms.RadioButton();
            this.AccordRB = new System.Windows.Forms.RadioButton();
            this.ResultDigitLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.marginTrackBar = new System.Windows.Forms.TrackBar();
            this.borderTrackBar = new System.Windows.Forms.TrackBar();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ResultPB = new System.Windows.Forms.PictureBox();
            this.SamplePB = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processedImgBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TraningSetLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderTrackBar)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePB)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVideoSource
            // 
            this.cmbVideoSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbVideoSource.FormattingEnabled = true;
            this.cmbVideoSource.Location = new System.Drawing.Point(19, 692);
            this.cmbVideoSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVideoSource.Name = "cmbVideoSource";
            this.cmbVideoSource.Size = new System.Drawing.Size(326, 28);
            this.cmbVideoSource.TabIndex = 1;
            this.cmbVideoSource.SelectionChangeCommitted += new System.EventHandler(this.cmbVideoSource_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 725);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор камеры";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(353, 692);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(89, 88);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestLable);
            this.groupBox1.Controls.Add(this.TestButton);
            this.groupBox1.Controls.Add(this.resolutionsBox);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.ticksLabel);
            this.groupBox1.Controls.Add(this.originalImageBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.cmbVideoSource);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(768, 798);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Камера";
            // 
            // TestLable
            // 
            this.TestLable.AutoSize = true;
            this.TestLable.Location = new System.Drawing.Point(618, 751);
            this.TestLable.Name = "TestLable";
            this.TestLable.Size = new System.Drawing.Size(52, 20);
            this.TestLable.TabIndex = 36;
            this.TestLable.Text = "Error: ";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(456, 743);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(145, 37);
            this.TestButton.TabIndex = 35;
            this.TestButton.Text = "Тест";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // resolutionsBox
            // 
            this.resolutionsBox.AllowDrop = true;
            this.resolutionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsBox.FormattingEnabled = true;
            this.resolutionsBox.Location = new System.Drawing.Point(19, 752);
            this.resolutionsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resolutionsBox.Name = "resolutionsBox";
            this.resolutionsBox.Size = new System.Drawing.Size(325, 28);
            this.resolutionsBox.TabIndex = 34;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(450, 692);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(113, 32);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Статус:";
            // 
            // ticksLabel
            // 
            this.ticksLabel.AutoSize = true;
            this.ticksLabel.Location = new System.Drawing.Point(564, 700);
            this.ticksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticksLabel.Name = "ticksLabel";
            this.ticksLabel.Size = new System.Drawing.Size(194, 20);
            this.ticksLabel.TabIndex = 30;
            this.ticksLabel.Text = "Ticks for frame processing";
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(8, 20);
            this.originalImageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(750, 662);
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.processedImgBox);
            this.panel1.Location = new System.Drawing.Point(778, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 682);
            this.panel1.TabIndex = 12;
            // 
            // processedImgBox
            // 
            this.processedImgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedImgBox.Location = new System.Drawing.Point(0, 0);
            this.processedImgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processedImgBox.Name = "processedImgBox";
            this.processedImgBox.Size = new System.Drawing.Size(662, 678);
            this.processedImgBox.TabIndex = 0;
            this.processedImgBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.StudyNetButton);
            this.panel2.Controls.Add(this.CreateNetButton);
            this.panel2.Controls.Add(this.NetStructureTB);
            this.panel2.Controls.Add(this.TraningSetLength);
            this.panel2.Controls.Add(this.StudentRB);
            this.panel2.Controls.Add(this.AccordRB);
            this.panel2.Controls.Add(this.ResultDigitLabel);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tresholdTrackBar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.marginTrackBar);
            this.panel2.Controls.Add(this.borderTrackBar);
            this.panel2.Location = new System.Drawing.Point(778, 712);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 207);
            this.panel2.TabIndex = 18;
            // 
            // StudyNetButton
            // 
            this.StudyNetButton.Location = new System.Drawing.Point(460, 150);
            this.StudyNetButton.Name = "StudyNetButton";
            this.StudyNetButton.Size = new System.Drawing.Size(178, 35);
            this.StudyNetButton.TabIndex = 31;
            this.StudyNetButton.Text = "Обучить";
            this.StudyNetButton.UseVisualStyleBackColor = true;
            this.StudyNetButton.Click += new System.EventHandler(this.StudyNetButton_Click);
            // 
            // CreateNetButton
            // 
            this.CreateNetButton.Location = new System.Drawing.Point(460, 107);
            this.CreateNetButton.Name = "CreateNetButton";
            this.CreateNetButton.Size = new System.Drawing.Size(178, 37);
            this.CreateNetButton.TabIndex = 30;
            this.CreateNetButton.Text = "Пересоздать сеть";
            this.CreateNetButton.UseVisualStyleBackColor = true;
            this.CreateNetButton.Click += new System.EventHandler(this.CreateNetButton_Click);
            // 
            // NetStructureTB
            // 
            this.NetStructureTB.Location = new System.Drawing.Point(308, 145);
            this.NetStructureTB.Name = "NetStructureTB";
            this.NetStructureTB.Size = new System.Drawing.Size(120, 26);
            this.NetStructureTB.TabIndex = 29;
            this.NetStructureTB.Text = "784;100;10";
            // 
            // TraningSetLength
            // 
            this.TraningSetLength.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TraningSetLength.Location = new System.Drawing.Point(308, 113);
            this.TraningSetLength.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.TraningSetLength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TraningSetLength.Name = "TraningSetLength";
            this.TraningSetLength.Size = new System.Drawing.Size(120, 26);
            this.TraningSetLength.TabIndex = 28;
            this.TraningSetLength.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // StudentRB
            // 
            this.StudentRB.AutoSize = true;
            this.StudentRB.Location = new System.Drawing.Point(172, 145);
            this.StudentRB.Name = "StudentRB";
            this.StudentRB.Size = new System.Drawing.Size(91, 24);
            this.StudentRB.TabIndex = 27;
            this.StudentRB.TabStop = true;
            this.StudentRB.Text = "Student";
            this.StudentRB.UseVisualStyleBackColor = true;
            this.StudentRB.CheckedChanged += new System.EventHandler(this.StudentRB_CheckedChanged);
            // 
            // AccordRB
            // 
            this.AccordRB.AutoSize = true;
            this.AccordRB.Location = new System.Drawing.Point(172, 115);
            this.AccordRB.Name = "AccordRB";
            this.AccordRB.Size = new System.Drawing.Size(84, 24);
            this.AccordRB.TabIndex = 26;
            this.AccordRB.TabStop = true;
            this.AccordRB.Text = "Accord";
            this.AccordRB.UseVisualStyleBackColor = true;
            this.AccordRB.CheckedChanged += new System.EventHandler(this.AccordRB_CheckedChanged);
            // 
            // ResultDigitLabel
            // 
            this.ResultDigitLabel.AutoSize = true;
            this.ResultDigitLabel.Location = new System.Drawing.Point(9, 165);
            this.ResultDigitLabel.Name = "ResultDigitLabel";
            this.ResultDigitLabel.Size = new System.Drawing.Size(59, 20);
            this.ResultDigitLabel.TabIndex = 25;
            this.ResultDigitLabel.Text = "Result:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 116);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Обработать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Порог";
            // 
            // tresholdTrackBar
            // 
            this.tresholdTrackBar.LargeChange = 1;
            this.tresholdTrackBar.Location = new System.Drawing.Point(446, 48);
            this.tresholdTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tresholdTrackBar.Maximum = 255;
            this.tresholdTrackBar.Name = "tresholdTrackBar";
            this.tresholdTrackBar.Size = new System.Drawing.Size(210, 69);
            this.tresholdTrackBar.TabIndex = 22;
            this.tresholdTrackBar.TickFrequency = 25;
            this.tresholdTrackBar.Value = 120;
            this.tresholdTrackBar.ValueChanged += new System.EventHandler(this.tresholdTrackBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Зазор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Поля";
            // 
            // marginTrackBar
            // 
            this.marginTrackBar.LargeChange = 10;
            this.marginTrackBar.Location = new System.Drawing.Point(228, 48);
            this.marginTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marginTrackBar.Maximum = 40;
            this.marginTrackBar.Name = "marginTrackBar";
            this.marginTrackBar.Size = new System.Drawing.Size(210, 69);
            this.marginTrackBar.TabIndex = 19;
            this.marginTrackBar.TickFrequency = 4;
            this.marginTrackBar.Value = 10;
            this.marginTrackBar.ValueChanged += new System.EventHandler(this.marginTrackBar_ValueChanged);
            // 
            // borderTrackBar
            // 
            this.borderTrackBar.LargeChange = 60;
            this.borderTrackBar.Location = new System.Drawing.Point(10, 48);
            this.borderTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.borderTrackBar.Maximum = 160;
            this.borderTrackBar.Name = "borderTrackBar";
            this.borderTrackBar.Size = new System.Drawing.Size(210, 69);
            this.borderTrackBar.TabIndex = 18;
            this.borderTrackBar.TickFrequency = 10;
            this.borderTrackBar.Value = 40;
            this.borderTrackBar.ValueChanged += new System.EventHandler(this.borderTrackBar_ValueChanged);
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.ProcessButton);
            this.controlPanel.Controls.Add(this.PlayButton);
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(1451, 420);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(198, 182);
            this.controlPanel.TabIndex = 33;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(4, 21);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(188, 62);
            this.ProcessButton.TabIndex = 26;
            this.ProcessButton.Text = "Обработать";
            this.ProcessButton.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(4, 93);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(188, 63);
            this.PlayButton.TabIndex = 25;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // ResultPB
            // 
            this.ResultPB.Location = new System.Drawing.Point(1451, 18);
            this.ResultPB.Name = "ResultPB";
            this.ResultPB.Size = new System.Drawing.Size(188, 185);
            this.ResultPB.TabIndex = 1;
            this.ResultPB.TabStop = false;
            // 
            // SamplePB
            // 
            this.SamplePB.Location = new System.Drawing.Point(1451, 235);
            this.SamplePB.Name = "SamplePB";
            this.SamplePB.Size = new System.Drawing.Size(188, 177);
            this.SamplePB.TabIndex = 34;
            this.SamplePB.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 820);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(739, 32);
            this.progressBar1.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1651, 934);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SamplePB);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.ResultPB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Распознавалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processedImgBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TraningSetLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderTrackBar)).EndInit();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVideoSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar marginTrackBar;
        private System.Windows.Forms.TrackBar borderTrackBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ticksLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tresholdTrackBar;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox processedImgBox;
        private System.Windows.Forms.ComboBox resolutionsBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label ResultDigitLabel;
        private System.Windows.Forms.Button StudyNetButton;
        private System.Windows.Forms.Button CreateNetButton;
        private System.Windows.Forms.TextBox NetStructureTB;
        private System.Windows.Forms.NumericUpDown TraningSetLength;
        private System.Windows.Forms.RadioButton StudentRB;
        private System.Windows.Forms.RadioButton AccordRB;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label TestLable;
        private System.Windows.Forms.PictureBox ResultPB;
        private System.Windows.Forms.PictureBox SamplePB;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

