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
        
        public bool Telitalálat = false;

        public VálaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Height = 100;
            Width = 300;
            //MouseClick += VálaszGomb_MouseClick;
        }

        //private void VálaszGomb_MouseClick(object? sender, MouseEventArgs e)
        //{
        //    Telitalálat = false;
        //    BackColor = Color.Red;
        //    Színezd();

        //}

        //void Színezd()
        //{
        //    if (HelyesVálasz == true)
        //    {
        //        BackColor = Color.Green;
        //        Telitalálat = true;
        //    }


        //}



    }
}
