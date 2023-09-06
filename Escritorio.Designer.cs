namespace AdivinaQuien
{
    partial class Escritorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            this.mesa = new System.Windows.Forms.Panel();
            this.Maso = new System.Windows.Forms.Panel();
            this.barra = new System.Windows.Forms.Panel();
            this.BtnAdivinar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.Ganador = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnReiniciarGanador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Panel();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.Bocina = new System.Windows.Forms.PictureBox();
            this.cartajugador = new System.Windows.Forms.PictureBox();
            this.carta1 = new System.Windows.Forms.PictureBox();
            this.carta2 = new System.Windows.Forms.PictureBox();
            this.carta3 = new System.Windows.Forms.PictureBox();
            this.carta4 = new System.Windows.Forms.PictureBox();
            this.carta5 = new System.Windows.Forms.PictureBox();
            this.carta6 = new System.Windows.Forms.PictureBox();
            this.carta7 = new System.Windows.Forms.PictureBox();
            this.carta8 = new System.Windows.Forms.PictureBox();
            this.carta9 = new System.Windows.Forms.PictureBox();
            this.carta10 = new System.Windows.Forms.PictureBox();
            this.mesa.SuspendLayout();
            this.Maso.SuspendLayout();
            this.barra.SuspendLayout();
            this.Ganador.SuspendLayout();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bocina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartajugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta10)).BeginInit();
            this.SuspendLayout();
            // 
            // mesa
            // 
            this.mesa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mesa.Controls.Add(this.Bocina);
            this.mesa.Controls.Add(this.cartajugador);
            this.mesa.Controls.Add(this.Maso);
            this.mesa.Controls.Add(this.barra);
            this.mesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesa.Location = new System.Drawing.Point(0, 0);
            this.mesa.Name = "mesa";
            this.mesa.Size = new System.Drawing.Size(692, 582);
            this.mesa.TabIndex = 0;
            // 
            // Maso
            // 
            this.Maso.BackColor = System.Drawing.Color.PaleGreen;
            this.Maso.Controls.Add(this.Ganador);
            this.Maso.Controls.Add(this.carta1);
            this.Maso.Controls.Add(this.carta2);
            this.Maso.Controls.Add(this.carta3);
            this.Maso.Controls.Add(this.carta4);
            this.Maso.Controls.Add(this.carta5);
            this.Maso.Controls.Add(this.carta6);
            this.Maso.Controls.Add(this.carta7);
            this.Maso.Controls.Add(this.carta8);
            this.Maso.Controls.Add(this.carta9);
            this.Maso.Controls.Add(this.carta10);
            this.Maso.Dock = System.Windows.Forms.DockStyle.Left;
            this.Maso.Location = new System.Drawing.Point(0, 0);
            this.Maso.Name = "Maso";
            this.Maso.Size = new System.Drawing.Size(338, 531);
            this.Maso.TabIndex = 12;
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.Green;
            this.barra.Controls.Add(this.BtnAdivinar);
            this.barra.Controls.Add(this.BtnFinalizar);
            this.barra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barra.Location = new System.Drawing.Point(0, 531);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(692, 51);
            this.barra.TabIndex = 11;
            // 
            // BtnAdivinar
            // 
            this.BtnAdivinar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdivinar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnAdivinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdivinar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdivinar.Location = new System.Drawing.Point(456, 16);
            this.BtnAdivinar.Name = "BtnAdivinar";
            this.BtnAdivinar.Size = new System.Drawing.Size(72, 23);
            this.BtnAdivinar.TabIndex = 0;
            this.BtnAdivinar.Text = "Adivinar";
            this.BtnAdivinar.UseVisualStyleBackColor = false;
            this.BtnAdivinar.Click += new System.EventHandler(this.BtnAdivinar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFinalizar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinalizar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.Location = new System.Drawing.Point(534, 16);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(57, 23);
            this.BtnFinalizar.TabIndex = 0;
            this.BtnFinalizar.Text = "Inicio";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // Ganador
            // 
            this.Ganador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ganador.BackColor = System.Drawing.Color.SeaGreen;
            this.Ganador.Controls.Add(this.BtnCerrar);
            this.Ganador.Controls.Add(this.BtnReiniciarGanador);
            this.Ganador.Controls.Add(this.label1);
            this.Ganador.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganador.Location = new System.Drawing.Point(186, 90);
            this.Ganador.Name = "Ganador";
            this.Ganador.Size = new System.Drawing.Size(326, 172);
            this.Ganador.TabIndex = 12;
            this.Ganador.Visible = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Location = new System.Drawing.Point(206, 121);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(81, 25);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnReiniciarGanador
            // 
            this.BtnReiniciarGanador.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnReiniciarGanador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReiniciarGanador.Location = new System.Drawing.Point(27, 121);
            this.BtnReiniciarGanador.Name = "BtnReiniciarGanador";
            this.BtnReiniciarGanador.Size = new System.Drawing.Size(103, 25);
            this.BtnReiniciarGanador.TabIndex = 1;
            this.BtnReiniciarGanador.Text = "Reiniciar";
            this.BtnReiniciarGanador.UseVisualStyleBackColor = false;
            this.BtnReiniciarGanador.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felicidades has Ganado!!";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Green;
            this.Login.Controls.Add(this.BtnIniciar);
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(692, 582);
            this.Login.TabIndex = 0;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIniciar.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(284, 537);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(86, 24);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Bocina
            // 
            this.Bocina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bocina.BackgroundImage = global::AdivinaQuien.Properties.Resources.volumenUp;
            this.Bocina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bocina.Location = new System.Drawing.Point(657, 3);
            this.Bocina.Name = "Bocina";
            this.Bocina.Size = new System.Drawing.Size(32, 32);
            this.Bocina.TabIndex = 13;
            this.Bocina.TabStop = false;
            this.Bocina.Click += new System.EventHandler(this.Bocina_Click);
            // 
            // cartajugador
            // 
            this.cartajugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cartajugador.BackColor = System.Drawing.SystemColors.Desktop;
            this.cartajugador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cartajugador.BackgroundImage")));
            this.cartajugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartajugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartajugador.InitialImage = ((System.Drawing.Image)(resources.GetObject("cartajugador.InitialImage")));
            this.cartajugador.Location = new System.Drawing.Point(597, 471);
            this.cartajugador.Name = "cartajugador";
            this.cartajugador.Size = new System.Drawing.Size(83, 99);
            this.cartajugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartajugador.TabIndex = 1;
            this.cartajugador.TabStop = false;
            // 
            // carta1
            // 
            this.carta1.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta1.BackgroundImage")));
            this.carta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta1.InitialImage = global::AdivinaQuien.Properties.Resources.LogoOso;
            this.carta1.Location = new System.Drawing.Point(11, 19);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(83, 99);
            this.carta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta1.TabIndex = 0;
            this.carta1.TabStop = false;
            this.carta1.Click += new System.EventHandler(this.carta1_Click);
            // 
            // carta2
            // 
            this.carta2.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta2.BackgroundImage")));
            this.carta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta2.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta2.InitialImage")));
            this.carta2.Location = new System.Drawing.Point(125, 19);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(83, 99);
            this.carta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta2.TabIndex = 6;
            this.carta2.TabStop = false;
            this.carta2.Click += new System.EventHandler(this.carta2_Click);
            // 
            // carta3
            // 
            this.carta3.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta3.BackgroundImage")));
            this.carta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta3.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta3.InitialImage")));
            this.carta3.Location = new System.Drawing.Point(239, 19);
            this.carta3.Name = "carta3";
            this.carta3.Size = new System.Drawing.Size(83, 99);
            this.carta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta3.TabIndex = 7;
            this.carta3.TabStop = false;
            this.carta3.Click += new System.EventHandler(this.carta3_Click);
            // 
            // carta4
            // 
            this.carta4.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta4.BackgroundImage")));
            this.carta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta4.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta4.InitialImage")));
            this.carta4.Location = new System.Drawing.Point(239, 292);
            this.carta4.Name = "carta4";
            this.carta4.Size = new System.Drawing.Size(83, 99);
            this.carta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta4.TabIndex = 8;
            this.carta4.TabStop = false;
            this.carta4.Click += new System.EventHandler(this.carta4_Click);
            // 
            // carta5
            // 
            this.carta5.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta5.BackgroundImage")));
            this.carta5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta5.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta5.InitialImage")));
            this.carta5.Location = new System.Drawing.Point(125, 407);
            this.carta5.Name = "carta5";
            this.carta5.Size = new System.Drawing.Size(83, 99);
            this.carta5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta5.TabIndex = 9;
            this.carta5.TabStop = false;
            this.carta5.Click += new System.EventHandler(this.carta5_Click);
            // 
            // carta6
            // 
            this.carta6.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta6.BackgroundImage")));
            this.carta6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta6.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta6.InitialImage")));
            this.carta6.Location = new System.Drawing.Point(11, 154);
            this.carta6.Name = "carta6";
            this.carta6.Size = new System.Drawing.Size(83, 99);
            this.carta6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta6.TabIndex = 4;
            this.carta6.TabStop = false;
            this.carta6.Click += new System.EventHandler(this.carta6_Click);
            // 
            // carta7
            // 
            this.carta7.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta7.BackgroundImage")));
            this.carta7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta7.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta7.InitialImage")));
            this.carta7.Location = new System.Drawing.Point(125, 154);
            this.carta7.Name = "carta7";
            this.carta7.Size = new System.Drawing.Size(83, 99);
            this.carta7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta7.TabIndex = 3;
            this.carta7.TabStop = false;
            this.carta7.Click += new System.EventHandler(this.carta7_Click);
            // 
            // carta8
            // 
            this.carta8.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta8.BackgroundImage")));
            this.carta8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta8.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta8.InitialImage")));
            this.carta8.Location = new System.Drawing.Point(239, 154);
            this.carta8.Name = "carta8";
            this.carta8.Size = new System.Drawing.Size(83, 99);
            this.carta8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta8.TabIndex = 2;
            this.carta8.TabStop = false;
            this.carta8.Click += new System.EventHandler(this.carta8_Click);
            // 
            // carta9
            // 
            this.carta9.BackColor = System.Drawing.SystemColors.InfoText;
            this.carta9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta9.BackgroundImage")));
            this.carta9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta9.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta9.InitialImage")));
            this.carta9.Location = new System.Drawing.Point(11, 292);
            this.carta9.Name = "carta9";
            this.carta9.Size = new System.Drawing.Size(83, 99);
            this.carta9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta9.TabIndex = 5;
            this.carta9.TabStop = false;
            this.carta9.Click += new System.EventHandler(this.carta9_Click);
            // 
            // carta10
            // 
            this.carta10.BackColor = System.Drawing.SystemColors.WindowText;
            this.carta10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carta10.BackgroundImage")));
            this.carta10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carta10.InitialImage = ((System.Drawing.Image)(resources.GetObject("carta10.InitialImage")));
            this.carta10.Location = new System.Drawing.Point(125, 292);
            this.carta10.Name = "carta10";
            this.carta10.Size = new System.Drawing.Size(83, 99);
            this.carta10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carta10.TabIndex = 10;
            this.carta10.TabStop = false;
            this.carta10.Click += new System.EventHandler(this.carta10_Click);
            // 
            // Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(692, 582);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.mesa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivina Quien";
            this.mesa.ResumeLayout(false);
            this.Maso.ResumeLayout(false);
            this.barra.ResumeLayout(false);
            this.Ganador.ResumeLayout(false);
            this.Ganador.PerformLayout();
            this.Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bocina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartajugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mesa;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.PictureBox carta10;
        private System.Windows.Forms.PictureBox carta5;
        private System.Windows.Forms.PictureBox carta4;
        private System.Windows.Forms.PictureBox carta3;
        private System.Windows.Forms.PictureBox carta2;
        private System.Windows.Forms.PictureBox carta9;
        private System.Windows.Forms.PictureBox carta6;
        private System.Windows.Forms.PictureBox carta7;
        private System.Windows.Forms.PictureBox carta8;
        private System.Windows.Forms.PictureBox cartajugador;
        private System.Windows.Forms.PictureBox carta1;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnAdivinar;
        private System.Windows.Forms.Panel Ganador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnReiniciarGanador;
        private System.Windows.Forms.Panel Maso;
        private System.Windows.Forms.PictureBox Bocina;
    }
}

