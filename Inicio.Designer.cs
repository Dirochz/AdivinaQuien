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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Pantalla = new System.Windows.Forms.Panel();
            this.Fondo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Versiones = new System.Windows.Forms.ComboBox();
            this.BtnNuevo = new System.Windows.Forms.PictureBox();
            this.BtnClasico = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.PictureBox();
            this.Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClasico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pantalla.Location = new System.Drawing.Point(0, 0);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(872, 593);
            this.Pantalla.TabIndex = 2;
            // 
            // Fondo
            // 
            this.Fondo.BackgroundImage = global::AdivinaQuien.Properties.Resources.Portada;
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fondo.Controls.Add(this.label1);
            this.Fondo.Controls.Add(this.Versiones);
            this.Fondo.Controls.Add(this.BtnNuevo);
            this.Fondo.Controls.Add(this.BtnClasico);
            this.Fondo.Controls.Add(this.BtnPlay);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(872, 593);
            this.Fondo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(355, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versiones de Juego\r\n";
            // 
            // Versiones
            // 
            this.Versiones.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Versiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Versiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Versiones.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versiones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Versiones.FormattingEnabled = true;
            this.Versiones.Location = new System.Drawing.Point(359, 404);
            this.Versiones.Name = "Versiones";
            this.Versiones.Size = new System.Drawing.Size(167, 27);
            this.Versiones.TabIndex = 3;
            this.Versiones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Image = global::AdivinaQuien.Properties.Resources.Nuevo;
            this.BtnNuevo.Location = new System.Drawing.Point(587, 369);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 95);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.TabStop = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnClasico
            // 
            this.BtnClasico.BackColor = System.Drawing.Color.Transparent;
            this.BtnClasico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClasico.Image = global::AdivinaQuien.Properties.Resources.Clasico;
            this.BtnClasico.Location = new System.Drawing.Point(191, 369);
            this.BtnClasico.Name = "BtnClasico";
            this.BtnClasico.Size = new System.Drawing.Size(115, 95);
            this.BtnClasico.TabIndex = 1;
            this.BtnClasico.TabStop = false;
            this.BtnClasico.Click += new System.EventHandler(this.BtnClasico_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.Enabled = false;
            this.BtnPlay.Image = global::AdivinaQuien.Properties.Resources.PlayDesactivado;
            this.BtnPlay.Location = new System.Drawing.Point(348, 531);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(194, 50);
            this.BtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 593);
            this.Controls.Add(this.Fondo);
            this.Controls.Add(this.Pantalla);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivina Quien";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClasico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnPlay;
        private System.Windows.Forms.PictureBox BtnClasico;
        private System.Windows.Forms.PictureBox BtnNuevo;
        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Panel Pantalla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Versiones;
    }
}