namespace Torres_de_Hanoi
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolucionar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cmbCantidadDeDiscos = new System.Windows.Forms.ComboBox();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.panelJuego.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "El juego de los discos: La Torre de Hanoi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSolucionar
            // 
            this.btnSolucionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolucionar.Location = new System.Drawing.Point(713, 406);
            this.btnSolucionar.Name = "btnSolucionar";
            this.btnSolucionar.Size = new System.Drawing.Size(75, 23);
            this.btnSolucionar.TabIndex = 17;
            this.btnSolucionar.Text = "Solucionar";
            this.btnSolucionar.UseVisualStyleBackColor = true;
            this.btnSolucionar.Visible = false;
            this.btnSolucionar.Click += new System.EventHandler(this.BtnSolucionar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(484, 406);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenú_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(364, 406);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // cmbCantidadDeDiscos
            // 
            this.cmbCantidadDeDiscos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadDeDiscos.FormattingEnabled = true;
            this.cmbCantidadDeDiscos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbCantidadDeDiscos.Location = new System.Drawing.Point(406, 205);
            this.cmbCantidadDeDiscos.Name = "cmbCantidadDeDiscos";
            this.cmbCantidadDeDiscos.Size = new System.Drawing.Size(55, 21);
            this.cmbCantidadDeDiscos.TabIndex = 5;
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstrucciones.Location = new System.Drawing.Point(16, 406);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(84, 23);
            this.btnInstrucciones.TabIndex = 4;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.BtnInstrucciones_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.Location = new System.Drawing.Point(244, 406);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de discos:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcelerar.Location = new System.Drawing.Point(600, 3);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(37, 23);
            this.btnAcelerar.TabIndex = 0;
            this.btnAcelerar.Text = ">>";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Visible = false;
            this.btnAcelerar.Click += new System.EventHandler(this.BtnAcelerar_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(557, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(37, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "II>";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // panelJuego
            // 
            this.panelJuego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJuego.Controls.Add(this.btnPlay);
            this.panelJuego.Controls.Add(this.btnAcelerar);
            this.panelJuego.Location = new System.Drawing.Point(12, 68);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(776, 332);
            this.panelJuego.TabIndex = 16;
            this.panelJuego.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.btnSolucionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cmbCantidadDeDiscos);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanoi";
            this.panelJuego.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCantidadDeDiscos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSolucionar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panelJuego;
    }
}

