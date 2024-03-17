using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósTeszt
{
    internal class VálaszGomb: TextBox
    {
        public bool HelyesVálasz = false;
        public int Talált = 0;
        public bool Telitalálat = false;
        public VálaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Height = 100;
            Width = 300;
            MouseClick += VálaszGomb_MouseClick;
        }

        private void VálaszGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Red;
            Színezd();
            Találat();

        }

        void Színezd()
        {
            if (HelyesVálasz == true)
            { 
                BackColor = Color.Green;
                Talált = 1;
            }
            
        }

        void Találat()
        {
            if (Talált == 1)
            {
                Talált = 0;
                Telitalálat = true;
            }
        }

    }
}
