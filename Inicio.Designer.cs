namespace AdivinaQuien
{
    partial class Inicio
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
            this.BtnPlay = new System.Windows.Forms.PictureBox();
            this.BtnClasico = new System.Windows.Forms.PictureBox();
            this.BtnNuevo = new System.Windows.Forms.PictureBox();
            this.Fondo = new System.Windows.Forms.Panel();
            this.Pantalla = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClasico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).BeginInit();
            this.Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.Enabled = false;
            this.BtnPlay.Image = global::AdivinaQuien.Properties.Resources.PlayDesactivado;
            this.BtnPlay.Location = new System.Drawing.Point(312, 388);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(194, 50);
            this.BtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnClasico
            // 
            this.BtnClasico.BackColor = System.Drawing.Color.Transparent;
            this.BtnClasico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClasico.Image = global::AdivinaQuien.Properties.Resources.Clasico;
            this.BtnClasico.Location = new System.Drawing.Point(187, 271);
            this.BtnClasico.Name = "BtnClasico";
            this.BtnClasico.Size = new System.Drawing.Size(115, 95);
            this.BtnClasico.TabIndex = 1;
            this.BtnClasico.TabStop = false;
            this.BtnClasico.Click += new System.EventHandler(this.BtnClasico_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Image = global::AdivinaQuien.Properties.Resources.Nuevo;
            this.BtnNuevo.Location = new System.Drawing.Point(514, 271);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 95);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.TabStop = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Fondo
            // 
            this.Fondo.BackgroundImage = global::AdivinaQuien.Properties.Resources.Portada;
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fondo.Controls.Add(this.BtnNuevo);
            this.Fondo.Controls.Add(this.BtnClasico);
            this.Fondo.Controls.Add(this.BtnPlay);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(800, 450);
            this.Fondo.TabIndex = 2;
            // 
            // Pantalla
            // 
            this.Pantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pantalla.Location = new System.Drawing.Point(0, 0);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(800, 450);
            this.Pantalla.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fondo);
            this.Controls.Add(this.Pantalla);
            this.DoubleBuffered = true;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClasico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).EndInit();
            this.Fondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnPlay;
        private System.Windows.Forms.PictureBox BtnClasico;
        private System.Windows.Forms.PictureBox BtnNuevo;
        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Panel Pantalla;
    }
}