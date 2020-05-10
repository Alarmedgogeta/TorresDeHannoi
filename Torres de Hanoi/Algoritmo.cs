using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_de_Hanoi
{
    class Algoritmo : Panel
    {
        static Torre origen, auxiliar, destino;
        static int cantidadDeDiscos;
        static Label contador;
        static ProgressBar progreso;
        static int aceleracion = 1;
        public static bool parar = false;
        public static void PrepararSolucion(Torre origen, Torre auxiliar, Torre destino, 
            int cantidadDeDiscos, Label contador, ProgressBar progreso)
        {
            Algoritmo.origen = origen;
            Algoritmo.auxiliar = auxiliar;
            Algoritmo.destino = destino;
            Algoritmo.cantidadDeDiscos = cantidadDeDiscos;
            Algoritmo.contador = contador;
            Algoritmo.progreso = progreso;
        }
        public static void Solucionar()
        {
            CheckForIllegalCrossThreadCalls = false;
            int ubicacionDelDisco1 = 1;
            for (int i = 1; i < Math.Pow(2, cantidadDeDiscos); i++)
            {
                switch (ubicacionDelDisco1)
                {
                    case 1:
                        if (!EsPar(i))
                        {
                            if (!EsPar(cantidadDeDiscos))
                            {
                                destino.Push(origen.Pop());
                                ubicacionDelDisco1 = 3;
                            }
                            else
                            {
                                auxiliar.Push(origen.Pop());
                                ubicacionDelDisco1 = 2;
                            }
                        }
                        else
                        {
                            if (destino.GetContador() == 0)
                            {
                                destino.Push(auxiliar.Pop());
                            }
                            else if (auxiliar.GetContador() == 0)
                            {
                                auxiliar.Push(destino.Pop());
                            }
                            else if (auxiliar.GetTamanioDeDisco() < destino.GetTamanioDeDisco())
                            {
                                destino.Push(auxiliar.Pop());
                            }
                            else
                            {
                                auxiliar.Push(destino.Pop());
                            }
                        }
                        break;
                    case 2:
                        if (!EsPar(i))
                        {
                            if (!EsPar(cantidadDeDiscos))
                            {
                                origen.Push(auxiliar.Pop());
                                ubicacionDelDisco1 = 1;
                            }
                            else
                            {
                                destino.Push(auxiliar.Pop());
                                ubicacionDelDisco1 = 3;
                            }
                        }
                        else
                        {
                            if (destino.GetContador() == 0)
                            {
                                destino.Push(origen.Pop());
                            }
                            else if (origen.GetContador() == 0)
                            {
                                origen.Push(destino.Pop());
                            }
                            else if (origen.GetTamanioDeDisco() < destino.GetTamanioDeDisco())
                            {
                                destino.Push(origen.Pop());
                            }
                            else
                            {
                                origen.Push(destino.Pop());
                            }
                        }
                        break;
                    case 3:
                        if (!EsPar(i))
                        {
                            if (!EsPar(cantidadDeDiscos))
                            {
                                auxiliar.Push(destino.Pop());
                                ubicacionDelDisco1 = 2;
                            }
                            else
                            {
                                origen.Push(destino.Pop());
                                ubicacionDelDisco1 = 1;
                            }
                        }
                        else
                        {
                            if (auxiliar.GetContador() == 0)
                            {
                                auxiliar.Push(origen.Pop());
                            }
                            else if (origen.GetContador() == 0)
                            {
                                origen.Push(auxiliar.Pop());
                            }
                            else if (origen.GetTamanioDeDisco() < auxiliar.GetTamanioDeDisco())
                            {
                                auxiliar.Push(origen.Pop());
                            }
                            else
                            {
                                origen.Push(auxiliar.Pop());
                            }
                        }
                        break;
                    default:
                        break;
                }
                origen.Refresh();
                auxiliar.Refresh();
                destino.Refresh();
                contador.Text = i.ToString();
                contador.Refresh();
                progreso.Value = (int)((i*100)/(Math.Pow(2, cantidadDeDiscos)-1));
                Thread.Sleep(1000/aceleracion);
                while (parar)
                {
                    Thread.Sleep(100);
                }
            }
        }

        public static void Acelerar()
        {
            if(aceleracion == 1)
            {
                aceleracion = 2;
            }else if(aceleracion == 2)
            {
                aceleracion = 4;
            }else if(aceleracion == 4)
            {
                aceleracion = 8;
            }
            else
            {
                aceleracion = 1;
            }
        }
        public static bool EsPar(int valor)
        {
            return ((valor % 2) == 0);
        }
    }
}
