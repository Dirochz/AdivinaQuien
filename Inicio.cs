using System;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace AdivinaQuien
{
    public partial class Inicio : Form
    {
        private string modo = string.Empty;
        private Metodos.Inicio obj = new Metodos.Inicio();

        public Inicio() { InitializeComponent(); }

        private void AbrirForm(Form form)
        {
            while (this.Pantalla.Controls.Count > 0) { this.Pantalla.Controls.RemoveAt(index: 0); }
            Form formHijo = form;
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.Pantalla.Controls.Add(formHijo);
            formHijo.Show();
        }

        public void CargarModo()
        {
            switch (modo)
            {
                case "Clasico":
                    this.AbrirForm(form: new Modo.Clasico());
                    break;

                case "Nuevo":
                    this.AbrirForm(form: new Modo.Nuevo());
                    break;
            }
        }

        // Botones
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            this.CargarModo();
            this.Fondo.Hide();
        }

        private void BtnClasico_Click(object sender, EventArgs e)
        {
            this.modo = "Clasico";
            this.BtnPlay.Enabled = true;
            this.BtnPlay.Image = Properties.Resources.REPRODUCIR_MUSICA;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.modo = "Nuevo";
            this.BtnPlay.Enabled = true;
            this.BtnPlay.Image = Properties.Resources.REPRODUCIR_MUSICA;
        }
    }
}
