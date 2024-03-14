namespace HajósTeszt
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktuálisKérdések;

        VálaszGomb VálaszGomb1;
        VálaszGomb VálaszGomb2;
        VálaszGomb VálaszGomb3;

        int AktuálisKérdés = 5;

        public Form1()
        {
            InitializeComponent();
            VálaszGomb1 = new VálaszGomb();
            VálaszGomb1.Top = 50;
            Controls.Add(VálaszGomb1);

            VálaszGomb2 = new VálaszGomb();
            VálaszGomb2.Top = 150;
            Controls.Add(VálaszGomb2);

            VálaszGomb3 = new VálaszGomb();
            VálaszGomb3.Top = 250;
            Controls.Add(VálaszGomb3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésBetöltés();
            List<Kérdés> AktuálisKérdések = new List<Kérdés>();
            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }

            dataGridView1.DataSource = AktuálisKérdések;
            Kérdésmegjelenítés(AktuálisKérdések[AktuálisKérdés]);

        }

        void Kérdésmegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            VálaszGomb1.Text = kérdés.Válasz1;
            VálaszGomb2.Text = kérdés.Válasz2;
            VálaszGomb3.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
        }

        List<Kérdés> KérdésBetöltés()
        {
            List<Kérdés> kérdések = new List<Kérdés>();

            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine() ?? "";
                    string[] tömb = sor.Split("\t");
                    if (tömb.Length != 7) continue;



                    Kérdés k = new Kérdés();
                    k.KérdésSzöveg = tömb[1];
                    k.Válasz1 = tömb[2];
                    k.Válasz2 = tömb[3];
                    k.Válasz3 = tömb[4];
                    k.URL = tömb[5];

                    int x = 0;
                    int.TryParse(tömb[6], out x);

                    k.HelyesVálasz = x;

                    kérdések.Add(k);
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }








            return kérdések;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            ;
        }
    }
}