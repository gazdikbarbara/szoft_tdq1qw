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
        int helyTop;
        int helyLeft;

        public Méreg()
        {
            int randomSzam = rnd.Next(1,11);
            Height = 20;
            Width = 20;
            Top = randomSzam * 20;
            Left = randomSzam * 20;
            BackColor = Color.Black;
        }
    }
}
