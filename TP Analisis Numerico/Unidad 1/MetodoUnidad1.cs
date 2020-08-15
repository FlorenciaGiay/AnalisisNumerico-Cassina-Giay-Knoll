using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace Unidad_1
{
    public class MetodoUnidad1
    {
        public Salida ObtenerRaiz(string metodo, int maxiteraciones, double tolerancia, double limiteizquierdo, double limitederecho)
        {
            Salida nuevaSalida = new Salida();
            if ((EvaluarFuncion(limiteizquierdo) * EvaluarFuncion(limitederecho)) > 0)
            {
                return null;
            }
            else if ((EvaluarFuncion(limiteizquierdo) * EvaluarFuncion(limitederecho)) == 0)
            {
                if (EvaluarFuncion(limitederecho) == 0)
                {
                    nuevaSalida.RaizEncontrada = limitederecho;
                }
                else
                {
                    nuevaSalida.RaizEncontrada = limiteizquierdo;
                }
            }
            else
            {
                double anterior = 0;
                int iteraciones = 0;
                iteraciones++;
                double raiz = 0;
                switch (metodo)
                {
                    case "Biseccion":
                        raiz = ObtenerRaizMetodoBiseccion(limitederecho, limiteizquierdo);
                        break;
                    case "Regla Falsa":
                        raiz = ObtenerRaizMetodoReglaFalsa(limitederecho, limiteizquierdo);
                        break;
                }
                double error = Math.Abs((raiz - anterior) / raiz);
                while (!(Math.Abs(EvaluarFuncion(raiz))<tolerancia || error < tolerancia || iteraciones>=maxiteraciones))
                {
                    if (EvaluarFuncion(limiteizquierdo)*EvaluarFuncion(raiz) > 0)
                    {
                        limiteizquierdo = raiz;
                    }
                    else
                    {
                        limitederecho = raiz;
                    }
                    anterior = raiz;
                    iteraciones++;
                    raiz = 0;
                    switch (metodo)
                    {
                        case "Biseccion":
                            raiz = ObtenerRaizMetodoBiseccion(limitederecho, limiteizquierdo);
                            break;
                        case "Regla Falsa":
                            raiz = ObtenerRaizMetodoReglaFalsa(limitederecho, limiteizquierdo);
                            break;
                    }
                    error = Math.Abs((raiz - anterior) / raiz);
                }
                nuevaSalida.RaizEncontrada = raiz;
                nuevaSalida.IteracionesRealizadas = iteraciones;
                nuevaSalida.ErrorRelativo = error;
            }
            return nuevaSalida;
        }

        public double ObtenerRaizMetodoBiseccion(double limitederecho, double limiteizquierdo)
        {
            return (limitederecho + limiteizquierdo) / 2;
        }

        public double ObtenerRaizMetodoReglaFalsa(double limitederecho, double limiteizquierdo)
        {
            return ((EvaluarFuncion(limitederecho)*limiteizquierdo-EvaluarFuncion(limiteizquierdo)*limitederecho)/(EvaluarFuncion(limitederecho)-EvaluarFuncion(limiteizquierdo)));
        }

        private double EvaluarFuncion (double x)
        {
            return Math.Pow(x,2)-4;
        }
    }
}
