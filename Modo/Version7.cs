using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaQuien.Modo
{
    public partial class Version7 : Form
    {
        private readonly SoundPlayer guitarra = new SoundPlayer(Properties.Resources.acustico);
        private readonly string baraja = Properties.Settings.Default.version;
        private readonly Metodos.General objmet = new Metodos.General();
        private readonly Metodos.Version7 thisobj = new Metodos.Version7();
        private bool musica = true;
        private bool notas = false;
        private bool Globo = false;
        private bool bajar1 = false;
        private bool bajar2 = false;
        private bool bajar3 = false;
        private bool bajar4 = false;
        private bool bajar5 = false;
        private bool bajar6 = false;
        private bool bajar7 = false;
        private bool bajar8 = false;
        private bool bajar9 = false;
        private bool bajar10 = false;
        private int inicio = 0;
        private string Opciones = "Nada";

        public Version7()
        {
            InitializeComponent();
            this.Color();
            this.Propiedad();
            this.CargarCartas();
            this.NombreNota();
        }

        public async void CargarCartas()
        {
            this.guitarra.Play();
            string carpeta = "C:\\AdivinaQuien\\" + this.baraja + "\\Mesa";
            Console.WriteLine(carpeta);

            if (Directory.Exists(carpeta))
            {
                if (Directory.GetFiles(carpeta).Length > 0 || Directory.GetDirectories(carpeta).Length > 0)
                {
                    await Partida();
                    int n = 1;
                    for (int i = 0; i < 10; i++)
                    {
                        PictureBox carta = Controls.Find("carta" + n, true).FirstOrDefault() as PictureBox;
                        if (carta != null)
                        {
                            string rutaImagen = "C:\\AdivinaQuien\\" + this.baraja + "\\Mesa\\" + n + ".png";
                            if (System.IO.File.Exists(rutaImagen))
                            {
                                carta.Image = System.Drawing.Image.FromFile(rutaImagen);
                                n++;
                            }
                            else
                            {
                                MessageBox.Show("La imagen no existe en la ubicación especificada para carta" + n + ".");
                                Application.Restart();
                                break;
                            }
                        }
                    }
                    MessageBox.Show("Selecciona la carta que usaras", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Para poder iniciar ingresar las cartas en C:\\AdivinaQuien", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show("Para poder iniciar ingresar las cartas en C:\\AdivinaQuien\\Mesa", "AdivinaQuien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task Partida()
        {
            if (musica == true)
            {
                await Task.Run(() =>
                {
                    guitarra.Load();
                    guitarra.PlayLooping();
                });
            }
            else
            {
                guitarra.Stop();
            }
        }

        public void Color()
        {
            //this.Jugador1.BackColor = ColorTranslator.FromHtml("#f7ede3");
            //this.Jugador2.BackColor = ColorTranslator.FromHtml("#f7ede3");
            //this.Jugador3.BackColor = ColorTranslator.FromHtml("#f7ede3");
            //this.Jugador4.BackColor = ColorTranslator.FromHtml("#f7ede3");
            //this.Jugador5.BackColor = ColorTranslator.FromHtml("#f7ede3");
            //this.Jugador6.BackColor = ColorTranslator.FromHtml("#f7ede3");

            this.nota1.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota2.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota3.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota4.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota5.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota6.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota7.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota8.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota9.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.nota10.BackColor = ColorTranslator.FromHtml("#f7ede3");
            this.BtnReiniciar.BackColor = ColorTranslator.FromHtml("#212e3d");
        }

        public void Propiedad()
        {
            this.nota1.ReadOnly = true;
            this.nota2.ReadOnly = true;
            this.nota3.ReadOnly = true;
            this.nota4.ReadOnly = true;
            this.nota5.ReadOnly = true;
            this.nota6.ReadOnly = true;
            this.nota7.ReadOnly = true;
            this.nota8.ReadOnly = true;
            this.nota9.ReadOnly = true;
            this.nota10.ReadOnly = true;
        }

        public void NombreNota()
        {
            nota1.Text = thisobj.NombreJson(1);
            nota2.Text = thisobj.NombreJson(2);
            nota3.Text = thisobj.NombreJson(3);
            nota4.Text = thisobj.NombreJson(4);
            nota5.Text = thisobj.NombreJson(5);
            nota6.Text = thisobj.NombreJson(6);
            nota7.Text = thisobj.NombreJson(7);
            nota8.Text = thisobj.NombreJson(8);
            nota9.Text = thisobj.NombreJson(9);
            nota10.Text = thisobj.NombreJson(10);
        }

        public void InfoJson()
        {
            Info.SetToolTip(this.carta1, thisobj.InfoJson(1));
            Info.SetToolTip(this.carta2, thisobj.InfoJson(2));
            Info.SetToolTip(this.carta3, thisobj.InfoJson(3));
            Info.SetToolTip(this.carta4, thisobj.InfoJson(4));
            Info.SetToolTip(this.carta5, thisobj.InfoJson(5));
            Info.SetToolTip(this.carta6, thisobj.InfoJson(6));
            Info.SetToolTip(this.carta7, thisobj.InfoJson(7));
            Info.SetToolTip(this.carta8, thisobj.InfoJson(8));
            Info.SetToolTip(this.carta9, thisobj.InfoJson(9));
            Info.SetToolTip(this.carta10, thisobj.InfoJson(10));
        }

        // Cambio
        private void Jugador1_TextChanged(object sender, EventArgs e)
        {
            this.Jugador1.BackColor = ColorTranslator.FromHtml("#f7ede3");
        }

        private void Jugador2_TextChanged(object sender, EventArgs e)
        {
            this.Jugador2.BackColor = ColorTranslator.FromHtml("#f7ede3");
        }

        private void Jugador3_TextChanged(object sender, EventArgs e)
        {
            this.Jugador3.BackColor = ColorTranslator.FromHtml("#f7ede3");
        }

        private void Jugador4_TextChanged(object sender, EventArgs e)
        {
            this.Jugador4.BackColor = ColorTranslator.FromHtml("#f7ede3");
        }

        private void Jugador5_TextChanged(object sender, EventArgs e)
        {
            this.Jugador5.BackColor = ColorTranslator.FromHtml("#f7ede3");
        }

        private void Jugador6_TextChanged(object sender, EventArgs e)
        {
            this.Jugador6.BackColor = ColorTranslator.FromHtml("#f7ede3");
        }

        // Boton
        private void Carta1_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\1.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar1 == false)
                {
                    this.carta1.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar1 = true;
                }
                else
                {
                    this.carta1.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\1.png");
                    this.bajar1 = false;
                }
            }
        }

        private async void Bocina_Click(object sender, EventArgs e)
        {
            if (musica == true)
            {
                musica = false;
                Bocina.BackgroundImage = Properties.Resources.volumenMuteB;
                await Partida();
            }
            else
            {
                musica = true;
                Bocina.BackgroundImage = Properties.Resources.volumenUpB;
                await Partida();
            }
        }

        private void TomarNota_Click(object sender, EventArgs e)
        {
            if (notas == true)
            {
                this.Nota.Hide();
                this.notas = false;
            }
            else
            {
                this.Nota.Show();
                this.notas = true;
            }
        }

        private void Carta2_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\2.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar2 == false)
                {
                    this.carta2.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar2 = true;
                }
                else
                {
                    this.carta2.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\2.png");
                    this.bajar2 = false;
                }
            }
        }

        private void Carta3_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\3.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar3 == false)
                {
                    this.carta3.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar3 = true;
                }
                else
                {
                    this.carta3.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\3.png");
                    this.bajar3 = false;
                }
            }
        }

        private void Carta4_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\4.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar4 == false)
                {
                    this.carta4.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar4 = true;
                }
                else
                {
                    this.carta4.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\4.png");
                    this.bajar4 = false;
                }
            }
        }

        private void Carta5_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\5.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar5 == false)
                {
                    this.carta5.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar5 = true;
                }
                else
                {
                    this.carta5.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\5.png");
                    this.bajar5 = false;
                }
            }
        }

        private void Carta6_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\6.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar6 == false)
                {
                    this.carta6.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar6 = true;
                }
                else
                {
                    this.carta6.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\6.png");
                    this.bajar6 = false;
                }
            }
        }

        private void Carta7_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\7.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar7 == false)
                {
                    this.carta7.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar7 = true;
                }
                else
                {
                    this.carta7.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\7.png");
                    this.bajar7 = false;
                }
            }
        }

        private void Carta8_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\8.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar8 == false)
                {
                    this.carta8.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar8 = true;
                }
                else
                {
                    this.carta8.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\8.png");
                    this.bajar8 = false;
                }
            }
        }

        private void Carta9_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\9.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar9 == false)
                {
                    this.carta9.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar9 = true;
                }
                else
                {
                    this.carta9.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\9.png");
                    this.bajar9 = false;
                }
            }
        }

        private void Carta10_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                this.cartaJugador.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Jugador\\10.png");
                this.inicio = 1;
            }
            else
            {
                if (this.bajar10 == false)
                {
                    this.carta10.Image = Properties.Resources.CartasAdivinaQuienV2;
                    this.bajar10 = true;
                }
                else
                {
                    this.carta10.Image = System.Drawing.Image.FromFile("C:\\AdivinaQuien\\" + baraja + "\\Mesa\\10.png");
                    this.bajar10 = false;
                }
            }
        }

        private void BotonInfo_Click(object sender, EventArgs e)
        {
            if (Globo == true)
            {
                Info.Active = false;
                this.Globo = false;
            }
            else
            {
                Info.Active = true;
                this.Globo = true;
                this.InfoJson();
            }
        }

        private void Img1Jug1_Click(object sender, EventArgs e) { Img1Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Lapiz_Click(object sender, EventArgs e)
        {
            switch (Opciones)
            {
                case "Nada":
                    Lapiz.Image = Properties.Resources.Interrogacion;
                    this.Opciones = "Interrogacion";
                    break;

                case "Interrogacion":
                    Lapiz.Image = Properties.Resources.Afavor;
                    this.Opciones = "Afavor";
                    break;

                case "Afavor":
                    Lapiz.Image = Properties.Resources.X;
                    this.Opciones = "X";
                    break;

                case "X":
                    Lapiz.Image = Properties.Resources.Borrador;
                    this.Opciones = "Nada";
                    break;
            }
        }

        private void Img1Jug2_Click(object sender, EventArgs e) { Img1Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img1Jug3_Click(object sender, EventArgs e) { Img1Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img1Jug4_Click(object sender, EventArgs e) { Img1Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img1Jug5_Click(object sender, EventArgs e) { Img1Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img1Jug6_Click(object sender, EventArgs e) { Img1Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img2Jug1_Click(object sender, EventArgs e) { Img2Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img3Jug1_Click(object sender, EventArgs e) { Img3Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img4Jug1_Click(object sender, EventArgs e) { Img4Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img5Jug1_Click(object sender, EventArgs e) { Img5Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img6Jug1_Click(object sender, EventArgs e) { Img6Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img7Jug1_Click(object sender, EventArgs e) { Img7Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img8Jug1_Click(object sender, EventArgs e) { Img8Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img9Jug1_Click(object sender, EventArgs e) { Img9Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img10Jug1_Click(object sender, EventArgs e) { Img10Jug1.Image = objmet.Anotacion(this.Opciones); }

        private void Img2Jug2_Click(object sender, EventArgs e) { Img2Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img3Jug2_Click(object sender, EventArgs e) { Img3Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img4Jug2_Click(object sender, EventArgs e) { Img4Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img5Jug2_Click(object sender, EventArgs e) { Img5Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img6Jug2_Click(object sender, EventArgs e) { Img6Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img7Jug2_Click(object sender, EventArgs e) { Img7Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img8Jug2_Click(object sender, EventArgs e) { Img8Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img9Jug2_Click(object sender, EventArgs e) { Img9Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img10Jug2_Click(object sender, EventArgs e) { Img10Jug2.Image = objmet.Anotacion(this.Opciones); }

        private void Img2Jug3_Click(object sender, EventArgs e) { Img2Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img3Jug3_Click(object sender, EventArgs e) { Img3Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img4Jug3_Click(object sender, EventArgs e) { Img4Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img5Jug3_Click(object sender, EventArgs e) { Img5Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img6Jug3_Click(object sender, EventArgs e) { Img6Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img7Jug3_Click(object sender, EventArgs e) { Img7Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img8Jug3_Click(object sender, EventArgs e) { Img8Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img9Jug3_Click(object sender, EventArgs e) { Img9Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img10Jug3_Click(object sender, EventArgs e) { Img10Jug3.Image = objmet.Anotacion(this.Opciones); }

        private void Img2Jug4_Click(object sender, EventArgs e) { Img2Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img3Jug4_Click(object sender, EventArgs e) { Img3Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img4Jug4_Click(object sender, EventArgs e) { Img4Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img5Jug4_Click(object sender, EventArgs e) { Img5Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img6Jug4_Click(object sender, EventArgs e) { Img6Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img7Jug4_Click(object sender, EventArgs e) { Img7Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img8Jug4_Click(object sender, EventArgs e) { Img8Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img9Jug4_Click(object sender, EventArgs e) { Img9Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img10Jug4_Click(object sender, EventArgs e) { Img10Jug4.Image = objmet.Anotacion(this.Opciones); }

        private void Img2Jug5_Click(object sender, EventArgs e) { Img2Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img3Jug5_Click(object sender, EventArgs e) { Img3Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img4Jug5_Click(object sender, EventArgs e) { Img4Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img5Jug5_Click(object sender, EventArgs e) { Img5Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img6Jug5_Click(object sender, EventArgs e) { Img6Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img7Jug5_Click(object sender, EventArgs e) { Img7Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img8Jug5_Click(object sender, EventArgs e) { Img8Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img9Jug5_Click(object sender, EventArgs e) { Img9Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img10Jug5_Click(object sender, EventArgs e) { Img10Jug5.Image = objmet.Anotacion(this.Opciones); }

        private void Img2Jug6_Click(object sender, EventArgs e) { Img2Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img3Jug6_Click(object sender, EventArgs e) { Img3Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img4Jug6_Click(object sender, EventArgs e) { Img4Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img5Jug6_Click(object sender, EventArgs e) { Img5Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img6Jug6_Click(object sender, EventArgs e) { Img6Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img7Jug6_Click(object sender, EventArgs e) { Img7Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img8Jug6_Click(object sender, EventArgs e) { Img8Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img9Jug6_Click(object sender, EventArgs e) { Img9Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void Img10Jug6_Click(object sender, EventArgs e) { Img10Jug6.Image = objmet.Anotacion(this.Opciones); }

        private void BtnReiniciar_Click(object sender, EventArgs e) { Application.Restart(); }
    }
}
