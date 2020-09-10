using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    public class MetodoUnidad2
    {
       public double[,] MetodoGaussJordan(int dimension, double[,] matriz)
       {
            for (int i = 0; i <= dimension-1; i++)
            {
                double coeficiente = matriz[i, i];
                for (int j = 0; j <= dimension; j++)
                {
                    matriz[i, j] = matriz[i, j] / coeficiente;
                }
                for (int j = 0; j <= dimension-1; j++)
                {
                    if (i != j)
                    {
                        coeficiente = matriz[j, i];
                        for (int k = 0; k <= dimension; k++)
                        {
                            matriz[j, k] = matriz[j, k] - (coeficiente * matriz[i, k]);
                        }
                    }
                }
            }
            /*
            double[] vectorResultado = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                vectorResultado[i] = matriz[i, dimension];
            }*/
            return matriz;
       }

        public double[,] MetodoGaussSeidel()
        {
            return null;
        }
    }
}
