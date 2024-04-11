using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace EuropeanCountries
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> orsz�glista = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = orsz�glista;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void Megnyit�sButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var t�mb = csv.GetRecords<CountryData>();
            foreach (var item in t�mb)
            {
                orsz�glista.Add(item);
            }
            sr.Close();
        }

        private void T�rl�sButton_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void Szerkeszt�sButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.CountryData = countryDataBindingSource.Current as CountryData;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(orsz�glista);
            };
        }
    }
}