using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_de_Hanoi
{
    public partial class Principal : Form
    {
        int movimientosRealizados = 0;
        bool mousePresionado = false;
        Point inicial;
        Torre previa;
        Thread solucion = new Thread(Algoritmo.Solucionar);
        /*
         * Aqui inicializo los labels que se ven ya iniciado el juego,
         * Hago esto poque cada que el juego finaliza el panel de juego se limpia
         * De esta forma lo puedo volver a llenar si se desea jugar de nuevo
         */
        Torre origen, auxiliar, destino;
        Label lblMensajeMinimo = new Label();
        Label lblMensajeMovimientos = new Label();
        Label lblMovimientosDelJugador = new Label();
        Label lblMovimientosMinimos = new Label();
        Label lblTorre1 = new Label();
        Label lblTorre2 = new Label();
        Label lblTorre3 = new Label();
        Label label4 = new Label();
        Label label6 = new Label();
        Label label9 = new Label();
        ProgressBar progreso = new System.Windows.Forms.ProgressBar();
        public Principal()
        {
            InitializeComponent();
            cmbCantidadDeDiscos.SelectedIndex = 0;
            progreso.Visible = false;
        }
        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;
            if (mousePresionado)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
            }
        }
        private void Ctr_MouseUp(object sender, MouseEventArgs e) {
            if (mousePresionado)
            {
                mousePresionado = false;
                Point ubicacion = ((Control)sender).Location;
                if ((ubicacion.X > label4.Location.X) && (ubicacion.X < (label4.Location.X + label4.Size.Width)))
                {
                    if (origen.GetContador() == 0)
                    {
                        origen.Push(previa.Pop());
                        if(origen != previa)
                        {
                            movimientosRealizados++;
                            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
                        }
                    }
                    else if (previa.GetTamanioDeDisco() <= origen.GetTamanioDeDisco())
                    {
                        origen.Push(previa.Pop());
                        if (origen != previa)
                        {
                            movimientosRealizados++;
                            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
                        }
                    }
                    else
                    {
                        previa.Push(previa.Pop());
                    }
                }
                else if ((ubicacion.X > label6.Location.X) && (ubicacion.X < (label6.Location.X + label6.Size.Width)))
                {
                    if (auxiliar.GetContador() == 0)
                    {
                        auxiliar.Push(previa.Pop());
                        if (auxiliar != previa)
                        {
                            movimientosRealizados++;
                            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
                        }
                    }
                    else if (previa.GetTamanioDeDisco() <= auxiliar.GetTamanioDeDisco())
                    {
                        auxiliar.Push(previa.Pop());
                        if (auxiliar != previa)
                        {
                            movimientosRealizados++;
                            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
                        }
                    }
                    else
                    {
                        previa.Push(previa.Pop());
                    }
                }
                else if ((ubicacion.X > label9.Location.X) && (ubicacion.X < (label9.Location.X + label9.Size.Width)))
                {
                    if (destino.GetContador() == 0)
                    {
                        destino.Push(previa.Pop());
                        if (destino != previa)
                        {
                            movimientosRealizados++;
                            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
                        }
                    }
                    else if (previa.GetTamanioDeDisco() <= destino.GetTamanioDeDisco())
                    {
                        destino.Push(previa.Pop());
                        if (destino != previa)
                        {
                            movimientosRealizados++;
                            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
                        }
                    }
                    else
                    {
                        previa.Push(previa.Pop());
                    }
                }
                else
                {
                    previa.Push(previa.Pop());
                }
                if (movimientosRealizados == 1)
                {
                    btnSolucionar.Enabled = false;
                    btnReiniciar.Enabled = true;
                }
                if (destino.GetContador() == (cmbCantidadDeDiscos.SelectedIndex+1))
                {
                    if(movimientosRealizados > int.Parse(lblMovimientosMinimos.Text))
                    {
                        MessageBox.Show("¡¡¡Ganaste!!!\n" +
                        "Muy bien, lo has conseguido, pero puedes mejorar.");
                    }
                    else
                    {
                        MessageBox.Show("¡¡¡Ganaste!!!\n" +
                            "¡Felicidades! Lo has conseguido en "+ lblMovimientosDelJugador.Text + 
                            " movimientos.");
                    }
                }
            }
        }
        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            //Verificamos que el click sea con el botón izquierdo del ratón
            if(e.Button == MouseButtons.Left)
            {
                inicial = e.Location;
                Point ubicacion = ((Control)sender).Location;
                //En este segmento de ifs verificamos de cual de las tres torres estamos tomando el disco
                if ((ubicacion.X > label4.Location.X)&&(ubicacion.X < (label4.Location.X + label4.Size.Width)))
                {
                    previa = origen;
                    //Verificamos si el disco que estamos tomando es el de hasta arriba
                    if (ubicacion.Y < (225-(20*(previa.GetContador()-1))))
                    {
                        if (!solucion.IsAlive)
                        {
                            mousePresionado = true;
                        }
                    }
                }else if ((ubicacion.X > label6.Location.X)&&(ubicacion.X < (label6.Location.X + label6.Size.Width)))
                {
                    previa = auxiliar;
                    if (ubicacion.Y < (225 - (20 * (previa.GetContador() - 1))))
                    {
                        if (!solucion.IsAlive)
                        {
                            mousePresionado = true;
                        }
                    }
                }else if ((ubicacion.X > label9.Location.X) && (ubicacion.X < (label9.Location.X + label9.Size.Width)))
                {
                    previa = destino;
                    if (ubicacion.Y < (225 - (20 * (previa.GetContador() - 1))))
                    {
                        if (!solucion.IsAlive)
                        {
                            mousePresionado = true;
                        }
                    }
                }
            }
        }
        private void InitializeLabels()
        {
            lblMensajeMinimo.Font = new Font(Font.FontFamily, 14);
            lblMensajeMinimo.AutoSize = true;
            lblMensajeMinimo.Text = "Mínimo de movimientos:";
            lblMensajeMovimientos.Font = new Font(Font.FontFamily, 14);
            lblMensajeMovimientos.AutoSize = true;
            lblMensajeMovimientos.Text = "Tu número de movimientos:";
            lblMovimientosDelJugador.Font = new Font(Font.FontFamily, 14);
            lblMovimientosDelJugador.Text = "0";
            lblMovimientosMinimos.Font = new Font(Font.FontFamily, 14);
            lblMovimientosMinimos.Text = "1";
            lblTorre1.Font = new Font(Font.FontFamily, 14);
            lblTorre1.Text = "Torre 1";
            lblTorre2.Font = new Font(Font.FontFamily, 14);
            lblTorre2.Text = "Torre 2";
            lblTorre3.Font = new Font(Font.FontFamily, 14);
            lblTorre3.Text = "Torre 3";
            label4.BackColor = System.Drawing.Color.Black;
            label6.BackColor = System.Drawing.Color.Black;
            label9.BackColor = System.Drawing.Color.Black;
            label4.Width = 200;
            label6.Width = 200;
            label9.Width = 200;
            label4.Height = 10;
            label6.Height = 10;
            label9.Height = 10;
        }
        private void MostrarLabels()
        {
            panelJuego.Controls.Add(origen);
            panelJuego.Controls.Add(auxiliar);
            panelJuego.Controls.Add(destino);
            panelJuego.Controls.Add(lblMensajeMinimo);
            panelJuego.Controls.Add(lblMensajeMovimientos);
            panelJuego.Controls.Add(lblMovimientosDelJugador);
            panelJuego.Controls.Add(lblMovimientosMinimos);
            panelJuego.Controls.Add(lblTorre1);
            panelJuego.Controls.Add(lblTorre2);
            panelJuego.Controls.Add(lblTorre3);
            panelJuego.Controls.Add(label4);
            panelJuego.Controls.Add(label6);
            panelJuego.Controls.Add(label9);
            panelJuego.Controls.Add(progreso);
            panelJuego.Controls.Add(btnAcelerar);
            panelJuego.Controls.Add(btnPlay);
        }
        private void UbicarLabels()
        {
            origen.Location = new Point(137, 45);
            auxiliar.Location = new Point(382, 45);
            destino.Location = new Point(622, 45);
            lblMensajeMinimo.Location = new Point(248, 269);
            lblMensajeMovimientos.Location = new Point(220, 300);
            lblMovimientosDelJugador.Location = new Point(477, 300);
            lblMovimientosMinimos.Location = new Point(477, 269);
            lblTorre1.Location = new Point(108, 235);
            lblTorre2.Location = new Point(354, 235);
            lblTorre3.Location = new Point(593, 235);
            label4.Location = new Point(42, 225);
            label6.Location = new Point(283, 225);
            label9.Location = new Point(522, 225);
            progreso.Location = new Point(230, 3);
            progreso.Size = new Size(315, 23);
        }
        private int CalcularMovimientosMinimos()
        {
            int movimientosMinimos;
            int numeroDeDiscos = cmbCantidadDeDiscos.SelectedIndex + 1;
            movimientosMinimos = (int) Math.Pow(2, numeroDeDiscos);
            movimientosMinimos--;
            return movimientosMinimos;
        }
        private void BtnInstrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tienes que mover los discos de la TORRE 1 a la TORRE 3.\n" +
                "Haz click sobre un disco y arrastralo hasta la torre donde deseas colocarlo.\n" +
                "Nunca se puede colocar un disco grande sobre uno pequeño.");
        }
        private void BtnSolucionar_Click(object sender, EventArgs e)
        {
            progreso.Visible = true; ;
            Algoritmo.PrepararSolucion(origen,auxiliar,destino,cmbCantidadDeDiscos.SelectedIndex+1,
                lblMovimientosDelJugador, progreso);
            solucion = new Thread(Algoritmo.Solucionar);
            solucion.Start();
            btnReiniciar.Enabled = true;
            btnSolucionar.Enabled = false;
            btnPlay.Visible = true;
            btnAcelerar.Visible = true;
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            if (solucion.IsAlive)
            {
                solucion.Abort();
            }
            btnPlay.Visible = false;
            btnAcelerar.Visible = false;
            progreso.Visible = false;
            panelJuego.Controls.Clear();
            btnReiniciar.Enabled = false;
            btnSolucionar.Enabled = true;
            movimientosRealizados = 0;
            int tamanioDeLasTorres = cmbCantidadDeDiscos.SelectedIndex + 1;
            origen = new Torre(tamanioDeLasTorres);
            auxiliar = new Torre(tamanioDeLasTorres);
            destino = new Torre(tamanioDeLasTorres);
            MostrarLabels();
            InitializeLabels();
            UbicarLabels();
            lblMovimientosMinimos.Text = CalcularMovimientosMinimos().ToString();
            for (int i = tamanioDeLasTorres; i > 0; i--)
            {
                origen.Push(new Disco(i));
            }
            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
            panelJuego.Controls.OfType<Control>().Where(ctr => ctr is Disco).ToList().ForEach(ctr =>
            {
                ctr.MouseDown += Ctr_MouseDown;
                ctr.MouseUp += Ctr_MouseUp;
                ctr.MouseMove += Ctr_MouseMove;
            });
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Algoritmo.parar = !Algoritmo.parar;
        }

        private void BtnAcelerar_Click(object sender, EventArgs e)
        {
            Algoritmo.Acelerar();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            int tamanioDeLasTorres = cmbCantidadDeDiscos.SelectedIndex + 1;
            origen = new Torre(tamanioDeLasTorres);
            auxiliar = new Torre(tamanioDeLasTorres);
            destino = new Torre(tamanioDeLasTorres);
            panelJuego.Visible = true;
            MostrarLabels();
            InitializeLabels();
            UbicarLabels();
            lblMovimientosMinimos.Text = CalcularMovimientosMinimos().ToString();
            for (int i = tamanioDeLasTorres; i > 0; i--)
            {
                origen.Push(new Disco(i));
            }
            btnMenu.Visible = true;
            btnReiniciar.Visible = true;
            btnSolucionar.Enabled = true;
            btnSolucionar.Visible = true;
            lblMovimientosDelJugador.Text = movimientosRealizados.ToString();
            btnJugar.Visible = false;
            panelJuego.Controls.OfType<Control>().Where(ctr => ctr is Disco).ToList().ForEach(ctr =>
            {
                ctr.MouseDown += Ctr_MouseDown;
                ctr.MouseUp += Ctr_MouseUp;
                ctr.MouseMove += Ctr_MouseMove;
            });
        }
        private void BtnMenú_Click(object sender, EventArgs e)
        {
            if (solucion.IsAlive)
            {
                solucion.Abort();
            }
            btnPlay.Visible = false;
            btnAcelerar.Visible = false;
            progreso.Visible = false;
            panelJuego.Visible = false;
            panelJuego.Controls.Clear();
            btnJugar.Visible = true;
            btnMenu.Visible = false;
            btnReiniciar.Visible = false;
            btnSolucionar.Visible = false;
            movimientosRealizados = 0;
        }
    }
}
