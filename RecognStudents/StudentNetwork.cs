using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AForge.WindowsForms
{
    public class StudentNetwork : BaseNetwork
    {
        public Stopwatch stopWatch = new Stopwatch();

        private List<Layer> Layers;
        private double Eta; 

        public StudentNetwork(int[] structure)
        {
            Eta = 0.1;
            Layers = new List<Layer>();
            Layer prev = null; 
            foreach (var length in structure)
            {
                Layer l = new Layer(length + 1, prev);
                Layers.Add(l);
                if (prev != null)
                {
                    int prevLen = prev.Length;
                    int currLen = l.Length;
                    prev.Weights = new double[prevLen, currLen - 1];
					Random r = new Random();
					for (int i = 0; i < prevLen; ++i)
						for (int j = 0; j < currLen - 1; ++j)
							prev.Weights[i, j] = r.NextDouble() - 0.5;
                }
                prev = l; 
            }
        }


        private double Train(double[] input, double[] desired)
        {
            Layer.Data = input;

            Layers.Last().ComputeValue();

            var error = Helpers.Error(Layers.Last().Input, desired);

            double[][] layDelts = new double[Layers.Count][];
            for (int i = 0; i < Layers.Count; ++i)
                layDelts[i] = new double[Layers[i].Length - 1];

            for (int li = Layers.Count - 1; li > 0; --li)
            {
                var layer = Layers[li];
                var layerLength = layer.Length - 1;

                if (li == Layers.Count - 1)
                {
                    for (int j = 0; j < layerLength; ++j)
                    {
                        var yj = layer[j];
                        layDelts[li][j] = yj * (1 - yj) * (desired[j] - yj);
                    }
                }
                else
                {
					for (int j = 0; j < layerLength; ++j)
                    {
                        var yj = layer[j];
                        var sum = 0.0;
                        for (int k = 0; k < layDelts[li + 1].Length; ++k)
                            sum += layDelts[li + 1][k] * layer.Weights[j, k];
                        layDelts[li][j] = yj * (1 - yj) * sum;
                    }
                }
            }

            for (int li = 1; li < Layers.Count; ++li)
                for (int i = 0; i < Layers[li - 1].Length; ++i)
                    for (int j = 0; j < Layers[li].Length - 1; ++j)
                        Layers[li - 1].Weights[i, j] += Eta * layDelts[li][j] * Layers[li - 1][i];
            
            return error;
        }

        public override int Train(Sample sample, double acceptableError, bool parallel)
        {
            int iters = 1;
            while (Train(sample.input, sample.Output) > acceptableError)
            {
                ++iters;
            }

            return iters;
        }

        private double TrainEpoch(double[][] inputs, double[][] outputs, bool parallel)
        {
			int x = 1;
            double err = 0.0;
            //if (parallel)
              //  Parallel.ForEach(inputs.Zip(outputs, (i, o) => new Tuple<double[], double[]>(i, o)), p => err += Train(p.Item1, p.Item2));
            
                foreach (var pair in inputs.Zip(outputs, (i, o) => new Tuple<double[], double[]>(i, o)))
                {
                    //while (Train(pair.Item1, pair.Item2) > 0.01) ;
                    //Eta = 1.0 / x++; 
                    err += Train(pair.Item1, pair.Item2);
                    //OnTrainProgress(((iter * 1.0) * inputs.Length + x++) / (total * inputs.Length), err, stopWatch.Elapsed);
                    //Console.WriteLine(x++);
                }

            return err;
        }

        private int iter = 0;
        private int total = 0;

        public override double TrainOnDataSet(SamplesSet samplesSet, int epochsCount, double acceptableError, bool parallel)
        {
            int epochs = 0;
            double err = double.MaxValue;

            double[][] inputs = new double[samplesSet.Count][];
            double[][] outputs = new double[samplesSet.Count][];

            //  Теперь массивы из samplesSet группируем в inputs и outputs
            for (int i = 0; i < samplesSet.Count; ++i)
            {
                var x = samplesSet[i].input.Length + 1;
                inputs[i] = new double[x];
                for (int j = 0; j < x - 1; ++j)
                    inputs[i][j] = samplesSet[i].input[j];
                inputs[i][x - 1] = 1;
                outputs[i] = samplesSet[i].Output;
            }

            stopWatch.Restart();

            double error = 0.0;
            iter = 0;
            total = epochsCount;

            while (epochs++ < epochsCount && (error = TrainEpoch(inputs, outputs, parallel)) > acceptableError)
            {
                ++iter;
#if DEBUG
                Console.WriteLine(epochs + " " + error);
#endif
                OnTrainProgress((epochs * 1.0) / epochsCount, error, stopWatch.Elapsed);
            }

            OnTrainProgress(1.0, err, stopWatch.Elapsed);

            stopWatch.Stop();

            return error;
        }

        protected override double[] Compute(double[] input)
        {
            Layer.Data = new double[input.Length + 1];
            for (int j = 0; j < input.Length; ++j)
                Layer.Data[j] = input[j];
            Layer.Data[input.Length] = 1;
            var last = Layers.Last();
            last.ComputeValue();
            return last.Input.Take(last.Input.Length - 1).ToArray();
        }
    }

    
}