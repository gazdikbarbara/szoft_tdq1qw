using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzíneződőGomb : Button
    {
        public SzíneződőGomb()
        {
            Height = 20;
            Width = 20;
            Click += SzíneződőGomb_Click;
           
        }

        
        private void SzíneződőGomb_Click(object? sender, EventArgs e)
        {
           BackColor = Color.Fuchsia;
        }

    }
}
