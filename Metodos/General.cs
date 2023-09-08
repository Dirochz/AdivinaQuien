using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaQuien.Metodos
{
    internal class General
    {
        public Image Anotacion(string Opciones)
        {
            Image obj = null;
            switch (Opciones)
            {
                case "Nada":
                    obj = null;
                break;

                case "Interrogacion":
                    obj = Properties.Resources.Interrogacion;
                break;

                case "Afavor":
                    obj = Properties.Resources.Afavor;
                break;

                case "X":
                    obj = Properties.Resources.X;
                break;
            }
            return obj;
        }
    }
}
