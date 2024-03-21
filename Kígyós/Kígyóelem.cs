using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kígyós
{
    internal class Kígyóelem : PictureBox
    {
        public static int Méret = 20;

        public Kígyóelem()
        {
            Width = Méret;
            Height = Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
