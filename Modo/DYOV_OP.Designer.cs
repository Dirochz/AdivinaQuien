namespace AdivinaQuien.Modo
{
    partial class DYOV_OP
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
            this.components = new System.ComponentModel.Container();
            this.Telon = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
            this.Principal = new System.Windows.Forms.Panel();
            this.Bocina = new System.Windows.Forms.PictureBox();
            this.SV = new System.Windows.Forms.Label();
            this.LFF = new System.Windows.Forms.Label();
            this.ZO = new System.Windows.Forms.Label();
            this.LosTres = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.PictureBox();
            this.Z = new System.Windows.Forms.PictureBox();
            this.Proximamente = new System.Windows.Forms.Panel();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.BtnBocina = new System.Windows.Forms.PictureBox();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bocina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LosTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            this.Proximamente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBocina)).BeginInit();
            this.SuspendLayout();
            // 
            // Telon
            // 
            this.Telon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Telon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Telon.Location = new System.Drawing.Point(0, 0);
            this.Telon.Name = "Telon";
            this.Telon.Size = new System.Drawing.Size(872, 593);
            this.Telon.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.AutomaticDelay = 0;
            this.Info.AutoPopDelay = 100000;
            this.Info.InitialDelay = 0;
            this.Info.ReshowDelay = 0;
            // 
            // Principal
            // 
            this.Principal.BackgroundImage = global::AdivinaQuien.Properties.Resources.Merry;
            this.Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Principal.Controls.Add(this.Bocina);
            this.Principal.Controls.Add(this.SV);
            this.Principal.Controls.Add(this.LFF);
            this.Principal.Controls.Add(this.ZO);
            this.Principal.Controls.Add(this.LosTres);
            this.Principal.Controls.Add(this.BtnPlay);
            this.Principal.Controls.Add(this.Z);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(872, 593);
            this.Principal.TabIndex = 0;
            // 
            // Bocina
            // 
            this.Bocina.BackColor = System.Drawing.Color.Transparent;
            this.Bocina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bocina.Image = global::AdivinaQuien.Properties.Resources.volumenUp;
            this.Bocina.Location = new System.Drawing.Point(12, 12);
            this.Bocina.Name = "Bocina";
            this.Bocina.Size = new System.Drawing.Size(34, 34);
            this.Bocina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bocina.TabIndex = 6;
            this.Bocina.TabStop = false;
            this.Bocina.Click += new System.EventHandler(this.Bocina_Click);
            // 
            // SV
            // 
            this.SV.BackColor = System.Drawing.Color.Transparent;
            this.SV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SV.Location = new System.Drawing.Point(686, 441);
            this.SV.Name = "SV";
            this.SV.Size = new System.Drawing.Size(100, 23);
            this.SV.TabIndex = 4;
            // 
            // LFF
            // 
            this.LFF.BackColor = System.Drawing.Color.Transparent;
            this.LFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LFF.Location = new System.Drawing.Point(388, 424);
            this.LFF.Name = "LFF";
            this.LFF.Size = new System.Drawing.Size(100, 23);
            this.LFF.TabIndex = 4;
            // 
            // ZO
            // 
            this.ZO.BackColor = System.Drawing.Color.Transparent;
            this.ZO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZO.Location = new System.Drawing.Point(83, 441);
            this.ZO.Name = "ZO";
            this.ZO.Size = new System.Drawing.Size(100, 23);
            this.ZO.TabIndex = 4;
            // 
            // LosTres
            // 
            this.LosTres.BackColor = System.Drawing.Color.Transparent;
            this.LosTres.Image = global::AdivinaQuien.Properties.Resources.ElCapitan_y_almirantes;
            this.LosTres.Location = new System.Drawing.Point(0, 341);
            this.LosTres.Name = "LosTres";
            this.LosTres.Size = new System.Drawing.Size(872, 252);
            this.LosTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LosTres.TabIndex = 0;
            this.LosTres.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.Image = global::AdivinaQuien.Properties.Resources.REPRODUCIR_MUSICA;
            this.BtnPlay.Location = new System.Drawing.Point(317, 96);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(183, 50);
            this.BtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // Z
            // 
            this.Z.BackColor = System.Drawing.Color.Transparent;
            this.Z.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Z.Image = global::AdivinaQuien.Properties.Resources.zoro;
            this.Z.Location = new System.Drawing.Point(810, 44);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(62, 50);
            this.Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Z.TabIndex = 1;
            this.Z.TabStop = false;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // Proximamente
            // 
            this.Proximamente.BackgroundImage = global::AdivinaQuien.Properties.Resources.Continue;
            this.Proximamente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proximamente.Controls.Add(this.BtnReiniciar);
            this.Proximamente.Controls.Add(this.BtnBocina);
            this.Proximamente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Proximamente.Location = new System.Drawing.Point(0, 0);
            this.Proximamente.Name = "Proximamente";
            this.Proximamente.Size = new System.Drawing.Size(872, 593);
            this.Proximamente.TabIndex = 0;
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReiniciar.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReiniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReiniciar.Location = new System.Drawing.Point(759, 12);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(110, 28);
            this.BtnReiniciar.TabIndex = 4;
            this.BtnReiniciar.Text = "Reiniciar";
            this.BtnReiniciar.UseVisualStyleBackColor = false;
            this.BtnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // BtnBocina
            // 
            this.BtnBocina.BackColor = System.Drawing.Color.Transparent;
            this.BtnBocina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBocina.Image = global::AdivinaQuien.Properties.Resources.volumenUpB;
            this.BtnBocina.Location = new System.Drawing.Point(12, 12);
            this.BtnBocina.Name = "BtnBocina";
            this.BtnBocina.Size = new System.Drawing.Size(34, 34);
            this.BtnBocina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBocina.TabIndex = 3;
            this.BtnBocina.TabStop = false;
            this.BtnBocina.Click += new System.EventHandler(this.BtnBocina_Click);
            // 
            // DYOV_OP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 593);
            this.Controls.Add(this.Telon);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Proximamente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DYOV_OP";
            this.Text = "DYOV_OP";
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bocina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LosTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            this.Proximamente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBocina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Principal;
        private System.Windows.Forms.Panel Telon;
        private System.Windows.Forms.PictureBox BtnBocina;
        private System.Windows.Forms.PictureBox BtnPlay;
        private System.Windows.Forms.PictureBox Z;
        private System.Windows.Forms.PictureBox LosTres;
        private System.Windows.Forms.Label ZO;
        private System.Windows.Forms.Label SV;
        private System.Windows.Forms.Label LFF;
        private System.Windows.Forms.ToolTip Info;
        private System.Windows.Forms.Panel Proximamente;
        private System.Windows.Forms.PictureBox Bocina;
        private System.Windows.Forms.Button BtnReiniciar;
    }
}