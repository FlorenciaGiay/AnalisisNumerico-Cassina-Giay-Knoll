using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    public class MetodoUnidad1
    {
        //Evaluar funcion
        private double EvaluarFuncion(double x)
        {
            return Math.Pow(x,2)-3;
        }

        //Metodos cerrados
        public Salida ObtenerRaizMetodosCerrados(string metodo, int maxiteraciones, double tolerancia, double limiteizquierdo, double limitederecho)
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

        //Metodos abiertos
        public Salida ObtenerRaizMetodoNewtonRaphson(int maxiteraciones, double tolerancia, double xi)
        {
            Salida nuevaSalida = new Salida();
            if(Math.Abs(EvaluarFuncion(xi))<tolerancia)
            {
                nuevaSalida.RaizEncontrada = xi;
            }
            else
            {
                int iteraciones = 0;
                double anterior1 = 0;
                double anterior2 = 0;
                double anterior3 = 0;
                iteraciones++;
                double derivada = (EvaluarFuncion(xi + tolerancia) - EvaluarFuncion(xi)) / tolerancia;
                if (derivada>0)
                {
                    double raiz = ObtenerRaizMetodoNewtonRaphson(xi, tolerancia, derivada);
                    double error = Math.Abs((raiz - anterior3) / raiz);
                    while (!(Math.Abs(EvaluarFuncion(raiz)) < tolerancia || error < tolerancia || iteraciones >= maxiteraciones))
                    {
                        xi = raiz;
                        anterior1 = anterior2;
                        anterior2 = anterior3;
                        anterior3 = raiz;
                        iteraciones++;
                        derivada = 1;
                        derivada = (EvaluarFuncion(xi + tolerancia) - EvaluarFuncion(xi)) / tolerancia;
                        if (derivada>0)
                        {
                            raiz = ObtenerRaizMetodoNewtonRaphson(xi, tolerancia, derivada);
                            error = Math.Abs((raiz - anterior3) / raiz);
                        }
                        else
                        {
                            nuevaSalida.Mensaje = "División por cero";
                            return nuevaSalida;
                        }
                    }
                    nuevaSalida.RaizEncontrada = raiz;
                    nuevaSalida.IteracionesRealizadas = iteraciones;
                    nuevaSalida.ErrorRelativo = error;
                    if (anterior1==anterior3 && anterior2==raiz)
                    {
                        nuevaSalida.Mensaje = "Bucle por mínimo, máximo o punto de inflexión";
                    }
                }
                else
                {
                    nuevaSalida.Mensaje = "División por cero";
                    return nuevaSalida;
                }
            }
            return nuevaSalida;
        }

        public Salida ObtenerRaizMetodoSecante(int maxiteraciones, double tolerancia, double xi)
        {
            Salida nuevaSalida = new Salida();
            if (Math.Abs(EvaluarFuncion(xi)) < tolerancia)
            {
                nuevaSalida.RaizEncontrada = xi;
            }
            else
            {
                int iteraciones = 0;
                double anterior = 0;
                iteraciones++;
                double denominador = EvaluarFuncion(xi + 1) - EvaluarFuncion(xi);
                if (denominador > 0)
                {
                    double raiz = 0;
                    raiz = ObtenerRaizMetodoSecante(xi, denominador);
                    double error = Math.Abs((raiz - anterior) / raiz);
                    while (!(Math.Abs(EvaluarFuncion(raiz)) < tolerancia || error < tolerancia || iteraciones >= maxiteraciones))
                    {
                        xi = raiz;
                        anterior = raiz;
                        iteraciones++;
                        denominador = EvaluarFuncion(xi + 1) - EvaluarFuncion(xi);
                        if (denominador > 0)
                        {
                            raiz = 0;
                            raiz = ObtenerRaizMetodoSecante(xi, denominador);
                            error = Math.Abs((raiz - anterior) / raiz);
                        }
                        else
                        {
                            nuevaSalida.Mensaje = "División por cero";
                            return nuevaSalida;
                        }
                    }
                    nuevaSalida.RaizEncontrada = raiz;
                    nuevaSalida.IteracionesRealizadas = iteraciones;
                    nuevaSalida.ErrorRelativo = error;
                }
                else
                {
                    nuevaSalida.Mensaje = "División por cero";
                    return nuevaSalida;
                }
            }
            return nuevaSalida;
        }

        public double ObtenerRaizMetodoNewtonRaphson(double xi, double tolerancia, double derivada)
        {
            return xi-(EvaluarFuncion(xi)/derivada);
        }

        public double ObtenerRaizMetodoSecante(double xi, double denominador)
        {
            return (EvaluarFuncion(xi + 1) * xi - EvaluarFuncion(xi) * (xi + 1)) / denominador;
        }


    }
}
