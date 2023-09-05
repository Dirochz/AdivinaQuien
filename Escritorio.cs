using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace AdivinaQuien
{
    public partial class Escritorio : Form
    {
        private int inicio = 0;
        private int pregunta = 0;
        private int aviso = 0;
        private SoundPlayer Lazer = new SoundPlayer(Properties.Resources.SpaceLaser);
        private SoundPlayer guitarra = new SoundPlayer(Properties.Resources.acustico);

        public Escritorio() { InitializeComponent(); }

        public void CargarCartas()
        {
            this.Lazer.Play();
            this.Lazer.Dispose();
            string carpeta = "C:\\AdivinaQuien\\Mesa";

            if (Directory.Exists(carpeta))
            {
                if (Directory.GetFiles(carpeta).Length > 0 || Directory.GetDirectories(carpeta).Length > 0)
                {
                    int n = 1;
                    for (int i = 0; i < 10; i++)
                    {
                        PictureBox carta = Controls.Find("carta" + n, true).FirstOrDefault() as PictureBox;
                        if (carta != null)
                        {
                            string rutaImagen = @"C:\AdivinaQuien\Mesa\" + n + ".jpg";
                            if (System.IO.File.Exists(rutaImagen))
                            {
                                carta.Image = System.Drawing.Image.FromFile(rutaImagen);
                                n++;
                            }
                            else
                            {
                                MessageBox.Show("La imagen no existe en la ubicación especificada para carta" + n + ".");
                            }
                        }
                    }
                    MessageBox.Show("Selecciona la carta que usaras", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Login.Show();
                    MessageBox.Show("Para poder iniciar ingresar las cartas en C:\\AdivinaQuien", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Para poder iniciar ingresar las cartas en C:\\AdivinaQuien\\Mesa", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botones
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            string urlcarpeta = "C:\\AdivinaQuien";
            try
            {
                if (Directory.Exists(urlcarpeta))
                {
                    this.Login.Hide();
                    this.CargarCartas();
                }
                else
                {
                    Directory.CreateDirectory(urlcarpeta);
                    MessageBox.Show("Para poder iniciar se creara la siguiente carpeta C:\\AdivinaQuien para colocar las cartas que se usaran en el juego", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("//////////////////////////////////////////////");
                Console.WriteLine("Error en Crear la Carpeta" + ex);
            }
        }

        private void carta1_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\1.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta1.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

        }

        private void carta2_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\2.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta2.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta3_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\3.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta3.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta4_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\4.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta4.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta5_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\5.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta5.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta6_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\6.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta6.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta7_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\7.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta7.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta8_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\8.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta8.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta9_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\9.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta9.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void carta10_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartajugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\Jugador\\9.jpg");
                this.inicio = 1;
            }
            else
            {
                if (pregunta == 1)
                {
                    this.carta10.Image = Properties.Resources.LogoOso;
                    pregunta = 0;
                }
                else { MessageBox.Show("Primero da clic en hacer pregunta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void BtnPregunta_Click(object sender, EventArgs e)
        {
            if (inicio == 0) { MessageBox.Show("Primero selecciona tu carta", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                if (aviso == 0)
                {
                    MessageBox.Show("Haz una pregunta descriptiva, esta alerta solo saldra una vez al hacer clic nuevamente puedes bajar la carta 1 vez", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aviso = 1;
                }
                this.pregunta = 1;
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e) { Application.Restart(); }

        private void BtnAdivinar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Adivinaste el Personaje?", "AdivinaQuien", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) { this.Ganador.Show(); }
            else
            {
                MessageBox.Show("Intenta descartar mas elementos, Animo!!", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e) { Application.Exit(); }

        private void cartajugador_BackgroundImageChanged(object sender, EventArgs e)
        {
            this.guitarra.Play();
            this.guitarra.Dispose();
        }
    }
}