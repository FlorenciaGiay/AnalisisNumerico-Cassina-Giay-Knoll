using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_3
{
    public class MetodoUnidad3
    {
        public List<double[]> ElementosCargados { get; set; }
        
        public MetodoUnidad3()
        {
            ElementosCargados = new List<double[]>();
        }
        public void CargarElemento (double x, double y)
        {
            double[] elemento = new double[2] { x, y };
            ElementosCargados.Add(elemento);
        }

        public int ObtenerN ()
        {
            return ElementosCargados.Count();
        }

        public void BorrarElementos (string condicion)
        {
            switch (condicion)
            {
                case "ultimo":
                    ElementosCargados.Remove(ElementosCargados.Last());
                    break;
                case "todos":
                    ElementosCargados.Clear();
                    break;
            }
        }

        private double CalcularSumatoria (string condicion)
        {
            double suma = 0;
            foreach (double[] elemento in ElementosCargados)
            {
                switch (condicion)
                {
                    case "x":
                        suma += elemento[0];
                        break;
                    case "y":
                        suma += elemento[1];
                        break;
                    case "xy":
                        suma += elemento[0] * elemento[1]; 
                        break;
                    case "x2":
                        suma += elemento[0] * elemento[0];     
                        break;
                }
            }
            return suma;
        }

        public Resultado CalcularAjusteRegresionLineal (double tolerancia)
        {
            Resultado ajuste = new Resultado();
            int n = ObtenerN();
            double sumatoriaX = CalcularSumatoria("x");
            double sumatoriaY = CalcularSumatoria("y");
            double sumatoriaXY = CalcularSumatoria("xy");
            double sumatoriaX2 = CalcularSumatoria("x2");
            double a1 = (n * sumatoriaXY - sumatoriaX * sumatoriaY) / (n * sumatoriaX2 - Math.Pow(sumatoriaX, 2));
            double a0 = (sumatoriaY / n) - (a1 * (sumatoriaX / n));
            double sr = 0;
            double st = 0;
            for (int i = 0; i < n-1; i++)
            {
                sr += Math.Pow((a1 * ElementosCargados[i][0]) + a0 - ElementosCargados[i][1], 2);
                st += Math.Pow((sumatoriaY / n) - ElementosCargados[i][1], 2);
            }
            double r = Math.Sqrt((st - sr) / st) * 100;
            ajuste.Funcion = $"y = {a1}x + {a0}";
            ajuste.PorcentajeEfectividad = $"{r}%";
            if (r < tolerancia)
            {
                ajuste.EfectividadAjuste = "El ajuste no es aceptable.";
            }
            else
            {
                ajuste.EfectividadAjuste = "El ajuste es aceptable.";
            }
            return ajuste;
        }

        public double[,] GenerarMatrizPolinomial(int grado)
        {
            double[,] matriz = new double[grado + 1, grado + 2];
            foreach (double[] elemento in ElementosCargados)
            {
                for (int i = 0; i < grado+1; i++)
                {
                    for (int j = 0; j < grado+1; j++)
                    {
                        matriz[i, j] += Math.Pow(elemento[0], i + j);
                    }
                    matriz[i, grado + 1] += elemento[1] * Math.Pow(elemento[0], i);
                }
            }
            return matriz;
        }

        public Resultado CalcularAjusteRegresionPolinomial(double tolerancia, double[] vectorResultados)
        {
            Resultado ajuste = new Resultado();
            string funcion = "";
            for (int i = 0; i < vectorResultados.Length; i++)
            {
                if (i==0)
                {
                    funcion = $"{vectorResultados[i]}x^{i}";
                }
                else
                {
                    funcion = $"{vectorResultados[i]}x^{i} + " + funcion;
                }
            }
            funcion = "y = " + funcion;
            /*double sumatoriaY = CalcularSumatoria("y");
            double n = ObtenerN();
            double sr = 0;
            double st = 0;
            for (int i = 0; i < n-1; i++)
            {
                sr += Math.Pow(Math.Abs(ElementosCargados[i][1] - EvaluarFuncion(vectorResultados, ElementosCargados[i][0])), 2);
                st += Math.Pow((sumatoriaY / n) - ElementosCargados[i][1], 2);
            }
            double r = Math.Sqrt((st - sr) / st) * 100;*/
            ajuste.Funcion = funcion;
            /*ajuste.PorcentajeEfectividad = $"{r}%";
            if (r < tolerancia)
            {
                ajuste.EfectividadAjuste = "El ajuste no es aceptable.";
            }
            else
            {
                ajuste.EfectividadAjuste = "El ajuste es aceptable.";
            }*/
            return ajuste;
        }

        private double EvaluarFuncion(double[] vector, double x)
        {
            double resultado = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                resultado += vector[i] * Math.Pow(x, i);
            }
            return resultado;
        }
    }
}
