using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace EuropeanCountries
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> országlista = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = országlista;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void MegnyitásButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                országlista.Add(item);
            }
            sr.Close();
        }

        private void TörlésButton_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void SzerkesztésButton_Click(object sender, EventArgs e)
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
                csv.WriteRecords(országlista);
            };
        }
    }
}