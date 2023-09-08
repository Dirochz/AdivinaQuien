using System;
using System.IO;
using System.Windows.Forms;

namespace AdivinaQuien
{
    public partial class Inicio : Form
    {
        private string modo = string.Empty;
        private readonly Metodos.Inicio obj = new Metodos.Inicio();

        public Inicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Cargarcarpeta();
        }

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

        private void Cargarcarpeta()
        {
            string rutaCarpeta = "C:\\AdivinaQuien";

            if (Directory.Exists(rutaCarpeta))
            {
                string[] carpetas = Directory.GetDirectories(rutaCarpeta);
                int posicionInicio = rutaCarpeta.Length + 1;

                foreach (string carpeta in carpetas)
                {
                    string nombreCarpeta = carpeta.Substring(posicionInicio);
                    Versiones.Items.Add(nombreCarpeta);
                }
                if (Versiones.Items.Count > 0) { Versiones.SelectedIndex = 0; }
            }
            else
            {
                Directory.CreateDirectory(rutaCarpeta);
                MessageBox.Show("Para poder iniciar se creara la siguiente carpeta C:\\AdivinaQuien para colocar las cartas que se usaran en el juego", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarModo()
        {
            switch (modo)
            {
                case "Clasico":
                    this.AbrirForm(form: new Modo.Clasico());
                    break;

                case "Nuevo":
                    this.AbrirForm(form: new Modo.Version7());
                    break;
            }
        }

        // Botones
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            string valorSeleccionado = Versiones.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(valorSeleccionado))
            {
                Properties.Settings.Default["version"] = valorSeleccionado;
                Properties.Settings.Default.Save();
                this.CargarModo();
                this.Fondo.Hide();
            }
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

        private void Inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                this.AbrirForm(form: new Modo.DYOV_OP());
                this.Fondo.Hide();
            }
        }
    }
}
