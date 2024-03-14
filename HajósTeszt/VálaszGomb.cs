using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósTeszt
{
    internal class VálaszGomb: TextBox
    {
        public VálaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Height = 70;
            Width = 300;
        }
    }
}
