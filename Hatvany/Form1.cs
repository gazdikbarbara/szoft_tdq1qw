namespace Hatvany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Szamok sz = new Szamok();
            sz.szám = 1;
            sz.hatvány = 2 ^ sz.szám;
            List<Szamok> listám = new List<Szamok>();







            dataGridView1.DataSource = listám;
        }
    }
}