using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies_adatbázis
{
    public partial class UserControl3 : UserControl
    {
        Models.StudiesContext stcontext = new Models.StudiesContext();
       
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            var oktatok = from x in stcontext.Instructors
                          select new
                          {
                              Titulus = x.Salutation,
                              Név = x.Name,
                              Sátusz = x.StatusFkNavigation.Name,
                              Alkalmazás = x.EmployementFkNavigation.Name,
                          };

            dataGridView1.DataSource = oktatok.ToList();
        }

        private void buttonMentés_Click(object sender, EventArgs e)
        {
            try
            {
                var oktatok = from x in stcontext.Instructors
                              select new
                              {
                                  Titulus = x.Salutation,
                                  Név = x.Name,
                                  Sátusz = x.StatusFkNavigation.Name,
                                  Alkalmazás = x.EmployementFkNavigation.Name,
                              };

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(oktatok);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
