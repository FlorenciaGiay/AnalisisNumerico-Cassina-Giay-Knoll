using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    public class MetodoUnidad2
    {
        public double[,] PivotearMatriz(double[,] matriz, int dimension)
        {
            double valormayor = matriz[0, 0];
            int indicemayor = 0;
            for (int i = 0; i < dimension; i++)
            {
                if (i>0)
                {
                    if (Math.Abs(matriz[i,0])>Math.Abs(valormayor))
                    {
                        valormayor = matriz[i, 0];
                        indicemayor = i;
                    }
                }
            }
            if (indicemayor!=0)
            {
                for (int i = 0; i < dimension + 1; i++)
                {
                    double aux = matriz[0, i];
                    matriz[0, i] = matriz[indicemayor, i];
                    matriz[indicemayor, i] = aux;
                }
            }
            return matriz;
        }
    }
}
