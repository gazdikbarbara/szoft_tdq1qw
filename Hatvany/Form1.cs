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
            sz.sz�m = 1;
            sz.hatv�ny = 2 ^ sz.sz�m;
            List<Szamok> list�m = new List<Szamok>();







            dataGridView1.DataSource = list�m;
        }
    }
}