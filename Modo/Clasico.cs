using AdivinaQuien.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaQuien.Modo
{
    public partial class Clasico : Form
    {
        private readonly SoundPlayer guitarra = new SoundPlayer(Properties.Resources.acustico);
        private readonly string baraja = Properties.Settings.Default.version;
        private readonly Metodos.Version7 thisobj = new Metodos.Version7();
        private bool musica = true;
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

        public Clasico()
        {
            InitializeComponent();
            this.CargarCartas();
            this.BtnReiniciar.BackColor = ColorTranslator.FromHtml("#212e3d");
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

        // Botones
        private async void Bocina_Click(object sender, EventArgs e)
        {
            if (musica == true)
            {
                musica = false;
                this.Bocina.BackgroundImage = Properties.Resources.volumenMuteB;
                await Partida();
            }
            else
            {
                musica = true;
                this.Bocina.BackgroundImage = Properties.Resources.volumenUpB;
                await Partida();
            }
        }

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

        private void BtnReiniciar_Click(object sender, EventArgs e) { Application.Restart(); }
    }
}
