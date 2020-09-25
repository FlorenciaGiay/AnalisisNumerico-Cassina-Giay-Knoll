using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    public class MetodoUnidad2
    {
       public double[] MetodoGaussJordan(int dimension, double[,] matriz)
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
            double[] vectorResultado = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                vectorResultado[i] = matriz[i, dimension];
            }
            return vectorResultado;
       }

        public double[] MetodoGaussSeidel(double[,] matriz, int dimension)
        {
            bool menorTolerancia = false;
            int contador = 0;
            double[] vectorResultado = new double[dimension];
            vectorResultado.Initialize();
            double[] vectorAnterior = new double[dimension];
            while (100 >= contador && menorTolerancia==false)
            {
                contador++;
                if (contador>1)
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }
                for (int i = 0; i < dimension; i++)
                {
                    double resultado = matriz[i, dimension];
                    double coeficienteIncognita = matriz[i, i];
                    for (int j = 0; j < dimension; j++)
                    {
                        if (i!=j)
                        {
                            resultado = resultado - (matriz[i, j] * vectorResultado[j]);
                        }
                    }
                    coeficienteIncognita = resultado / coeficienteIncognita;
                    vectorResultado[i] = coeficienteIncognita;
                }
                for (int i = 0; i < dimension; i++)
                {
                    if (Math.Abs(vectorResultado[i]-vectorAnterior[i])==0) // Si usamos tolerancia ponemos <0.0001 y cambiamos el DialogBox de resultado.
                    {
                        menorTolerancia = true;
                    }
                }
            }
            if (contador >= 100)
            {
                return null;
            }
            else
            {
                return vectorResultado;
            }
        }
    }
}
