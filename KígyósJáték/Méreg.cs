using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJáték
{
    internal class Méreg : Button
    {
        Random rnd = new Random();
        int helyTop = 50;
        int helyLeft = 20;
        int randomSzam;

        public Méreg()
        {
            randomSzam = rnd.Next(1,21);
            Height = 20;
            Width = 20;
            Top = helyTop * randomSzam;
            Left = helyLeft * randomSzam;
            BackColor = Color.Black;
        }
    }
}
