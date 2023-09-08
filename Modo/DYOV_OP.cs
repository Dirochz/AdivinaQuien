using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaQuien.Modo
{
    public partial class DYOV_OP : Form
    {
        private bool musica = true;
        private bool musica2 = true;
        private readonly SoundPlayer guitarra = new SoundPlayer(Properties.Resources.We_ARE_);
        private readonly SoundPlayer continuee = new SoundPlayer(Properties.Resources.One_Piece_OST);

        public DYOV_OP()
        {
            InitializeComponent();
            guitarra.Play();
            this.Telon.Hide();
            Info.SetToolTip(this.ZO, "Si muero aquí, significa que no estaba destinado a llegar más lejos");
            Info.SetToolTip(this.LFF, "Si no arriesgas tu vida, no puedes crear un futuro");
            Info.SetToolTip(this.SV, "¡Un hombre de verdad es aquel que perdona a la mujer por sus mentiras!");
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

        private async Task continuees()
        {
            if (musica2 == true)
            {
                await Task.Run(() =>
                {
                    continuee.Load();
                    continuee.PlayLooping();
                });
            }
            else
            {
                continuee.Stop();
            }
        }

        private async void BtnBocina_Click(object sender, EventArgs e)
        {
            if (musica2 == true)
            {
                musica2 = false;
                BtnBocina.BackgroundImage = Properties.Resources.volumenMuteB;
                await continuees();
            }
            else
            {
                musica2 = true;
                BtnBocina.BackgroundImage = Properties.Resources.volumenUpB;
                await continuees();
            }
        }

        private async void Bocina_Click(object sender, EventArgs e)
        {
            if (musica == true)
            {
                musica = false;
                Bocina.BackgroundImage = Properties.Resources.volumenMute;
                await Partida();
            }
            else
            {
                musica = true;
                Bocina.BackgroundImage = Properties.Resources.volumenUp;
                await Partida();
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            this.Principal.Hide();
            guitarra.Stop();
            continuee.Play();
        }

        private void BtnReiniciar_Click(object sender, EventArgs e) { Application.Restart(); }

        private void Z_Click(object sender, EventArgs e) { Z.Image = Properties.Resources.michiZoro; }
    }
}
