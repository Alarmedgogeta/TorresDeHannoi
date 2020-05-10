using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_de_Hanoi
{
    class Torre : Label
    {
        int contador = 0;
        Disco[] pila;
        public Torre(int tamanio)
        {
            this.pila = new Disco[tamanio];
            this.BackColor = System.Drawing.Color.Black;
            this.Width = 10;
            this.Height = 180;
        }
        public int GetContador()
        {
            return contador;
        }
        private bool EstaLleno()
        {
            return contador == pila.Length;
        }
        private bool EstaVacio()
        {
            return contador == 0;
        }
        public int Push(Disco disco)
        {
            if (!EstaLleno())
            {
                if (!EstaVacio())
                {
                    if(pila[contador-1].GetTamanio() > disco.GetTamanio())
                    {
                        pila[contador] = disco;
                        this.Parent.Controls.Add(disco);
                        disco.Location = new System.Drawing.Point(this.Location.X - (disco.Width / 2) + (this.Width / 2), 225-(20*(contador+1)));
                        disco.BringToFront();
                        disco.Refresh();
                        contador++;
                        return 0;
                    }
                }
                else
                {
                    pila[contador] = disco;
                    this.Parent.Controls.Add(disco);
                    disco.Location = new System.Drawing.Point(this.Location.X - (disco.Width / 2)+(this.Width / 2), 225 - (20 * (contador + 1)));
                    disco.BringToFront();
                    disco.Refresh();
                    contador++;
                    return 0;
                }
            }
            return 1;
        }
        public Disco Pop()
        {
            Disco disco = null;
            if (!EstaVacio())
            {
                contador--;
                disco = pila[contador];
                pila[contador] = null;
                //return pila[contador];
            }
            return disco;
        }
        public int GetTamanioDeDisco()
        {
            return pila[contador-1].GetTamanio();
        }
    }
}
