using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_4
{
    public class MetodoUnidad4
    {
        private double EvaluarFuncion(double x)
        {
            return 0.2+25*x-200*Math.Pow(x,2)+675*Math.Pow(x,3)-900*Math.Pow(x,4)+400*Math.Pow(x,5);
        }

        public double CalcularIntegralTrapecioSimple (double a, double b)
        {
            return ((EvaluarFuncion(a)+EvaluarFuncion(b))*(b-a))/2;
        } 

        public double CalcularIntegralTrapeciosMultiples (double a, double b, int n)
        {
            double h = (b - a) / n;
            double Sum = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                Sum += EvaluarFuncion((i * h) + a);
            }
            return (h / 2) * (EvaluarFuncion(a) + (Sum * 2) + EvaluarFuncion(b));
        }

        public double CalcularIntegralSimpson1_3Simple (double a, double b)
        {
            double h = (b - a) / 2;
            return (h / 3) * (EvaluarFuncion(a) + 4 * EvaluarFuncion(a + h) + EvaluarFuncion(b));
        }

        public double CalcularIntegralSimpson1_3Multiple (double a, double b, int n)
        {
            double h = (b - a) / n;
            double SumPares = 0;
            double SumImpares = 0;
            for (int i = 1; i <= n-1; i++)
            {
                if (i % 2 == 0)
                {
                    SumPares += EvaluarFuncion(a+(i*h));
                }
                else
                {
                    SumImpares += EvaluarFuncion(a + (i * h));
                }
            }
            return (EvaluarFuncion(a) + 4 * SumImpares + 2 * SumPares + EvaluarFuncion(b)) * (h / 3);
        }

        public double CalcularIntegralSimpson3_8 (double a, double b)
        {
            double h = (b - a)/3;
            return (3 * h / 8) * (EvaluarFuncion(a) + 3 * EvaluarFuncion(a + h) + 3 * EvaluarFuncion(a + 2 * h) + EvaluarFuncion(b));
        }
    }
}
