using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForge.WindowsForms
{
    public class Matrix
    {
        public double[,] Value;
        public int I => Value.GetLength(0);
        public int J => Value.GetLength(1);

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i > I || j < 0 || j > J)
                    throw new ArgumentException("Wrong idices");
                else
                    return Value[i, j];
            }
            set
            {
                if (i < 0 || i > I || j < 0 || j > J)
                    throw new ArgumentException("Wrong idices");
                else
                    Value[i, j] = value;
            }
        }

        public double this[int i]
        {
            get
            {
                if (i < 0 || i > J)
                    throw new ArgumentException("Wrong idices");
                else
                    return Value[0, i];
            }
            set
            {
                if (i < 0 || i > J)
                    throw new ArgumentException("Wrong idices");
                else
                    Value[0, i] = value;
            }
        }

        public Matrix(double[,] arr)
        {
            Value = arr;
        }

        public static Matrix operator *(Matrix one, Matrix other)
        {
            double[,] matr = new double[one.Value.GetLength(0), other.Value.GetLength(1)];

            for (int i = 0; i < one.Value.GetLength(0); i++)
            {
                for (int j = 0; j < other.Value.GetLength(1); j++)
                {
                    for (int k = 0; k < one.Value.GetLength(1); k++)
                    {
                        matr[i, j] += one.Value[i, k] * other.Value[k, j];
                    }
                }
            }
            Matrix res = new Matrix(matr);
            return res;
        }

        public static explicit operator Matrix(double[,] mart)
        {
            return new Matrix(mart);
        }

        public static explicit operator Matrix(double[] matr)
        {
            double[,] val = new double[1, matr.Length];
            for (int i = 0; i < matr.Length; ++i)
                val[0, i] = matr[i];
            return new Matrix(val);
        }
    }
}
