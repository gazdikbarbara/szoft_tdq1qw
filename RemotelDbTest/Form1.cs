namespace RemotelDbTest
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keresni = textBox1.Text;
            var eredmény = from x in studentContext.Students
                           where x.Name.StartsWith(keresni)
                           select x;

            dataGridView1.DataSource = eredmény.ToList();
        }
    }
}