using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForge.WindowsForms
{
    public class Layer
    {
        public double[] Input;
        public Layer Previous;
        public double[,] Weights;
        public int Length => Input.Length;

        public Layer(int length, Layer previous)
        {
            if (length <= 0)
                throw new ArgumentException("Length should be greater than zero");
            Input = new double[length];
            Input[length - 1] = 1;
            Previous = previous;
        }

        public double[] ProduceValue()
        {
            var temp = Helpers.Mult(Input, Weights);
            Helpers.SigmoidAll(temp);
            return temp;
        }

        public void ComputeValue()
        {
            if (Previous == null)
                Input = Data;
            else
            {
                Previous.ComputeValue();
                var temp = Previous.ProduceValue();
                var n = new double[temp.Length + 1];
                for (int j = 0; j < temp.Length; ++j)
                    n[j] = temp[j];
                n[temp.Length] = 1;
                Input = n; 
            }

        }

        public double this[int i]
        {
            get
            {
                if (i < 0 || i > Length)
                    throw new ArgumentException("Wrong index");
                else
                    return Input[i];
            }
        }

        public static double[] Data;
    }
}
