using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJáték
{
    internal class KígyóElem: PictureBox
    {
        public static int Méret = 20;

        public KígyóElem()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
