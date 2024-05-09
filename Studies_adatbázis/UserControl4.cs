using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies_adatbázis
{
    public partial class UserControl4 : UserControl
    {
        Models.StudiesContext studcontext = new Models.StudiesContext();
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            var kurzusok = from x in studcontext.Courses
                           select new
                           {
                               Név = x.Name,
                               Kód = x.Code,
                           };

            dataGridView1.DataSource = kurzusok.ToList();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }
    }
}
