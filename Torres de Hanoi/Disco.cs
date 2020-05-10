using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_de_Hanoi
{
    class Disco : Label
    {
        private int tamanio;
        public Disco(int tamanio)
        {
            this.tamanio = tamanio;
            Personalizar(tamanio);
        }
        public void Personalizar(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    this.BackColor = System.Drawing.Color.Coral;
                    this.Width = 50;
                    this.Height = 20;
                    break;
                case 2:
                    this.BackColor = System.Drawing.Color.Fuchsia;
                    this.Width = 70;
                    this.Height = 20;
                    break;
                case 3:
                    this.BackColor = System.Drawing.Color.Purple;
                    this.Width = 90;
                    this.Height = 20;
                    break;
                case 4:
                    this.BackColor = System.Drawing.Color.Blue;
                    this.Width = 110;
                    this.Height = 20;
                    break;
                case 5:
                    this.BackColor = System.Drawing.Color.Green;
                    this.Width = 130;
                    this.Height = 20;
                    break;
                case 6:
                    this.BackColor = System.Drawing.Color.Yellow;
                    this.Width = 150;
                    this.Height = 20;
                    break;
                case 7:
                    this.BackColor = System.Drawing.Color.Orange;
                    this.Width = 170;
                    this.Height = 20;
                    break;
                case 8:
                    this.BackColor = System.Drawing.Color.Red;
                    this.Width = 190;
                    this.Height = 20;
                    break;
            }
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        public int GetTamanio()
        {
            return tamanio;
        }
    }
}
