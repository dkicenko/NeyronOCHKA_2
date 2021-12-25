using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace AForge.WindowsForms
{
    public static class Helpers
    {
        public static double Error(double[] a, double[] b)
        {
            double err = 0.0;
            for (int i = 0; i < b.Length; i++)
                err += (a[i] - b[i])* (a[i] - b[i]);
            return err / 2;
        }

		public static double[] Mult(double[] vec, double[,] matr)
		{
			double[] res = new double[matr.GetLength(1)];
			Parallel.For(0, matr.GetLength(1), j =>
			{
				double a = 0.0;
				for (int i = 0; i < vec.Length; ++i)
				{
					a += vec[i] * matr[i, j];
				}
				res[j] = a;
			});
			/*for (int j = 0; j < matr.GetLength(1); ++j)
			{
				double a = 0.0;
				for (int i = 0; i < vec.Length; ++i)
				{
					a += vec[i] * matr[i, j]; 
				}
				res[j] = a;
			}*/
			return res;
		}

        public static double Sigmoig(double x) => 1 / (1 + Exp(-x));

        public static double SigmoidDiff(double x)
        {
            var temp = Sigmoig(x);
            return temp - temp * temp;
        }

		public static void SigmoidAll(double[] matr)
		{
			// Parallel.For()
			Parallel.For(0, matr.Length, i => matr[i] = Sigmoig(matr[i]));
			//for (int i = 0; i < matr.Length; i++)
				//matr[i] = Sigmoig(matr[i]);
		}
    }
}
