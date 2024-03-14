namespace Hajós
{
    public partial class Form1 : Form
    {
        List<Kerdes> ÖsszesKerdérdés;
        List<Kerdes> AktuálisKérdések = new List<Kerdes>();
        int MegjelenítettKérdésszám = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKerdérdés = KérdésekBeolvasása();

            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKerdérdés[0]);
                ÖsszesKerdérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktuálisKérdések;
            KérdésMegjelenítése(AktuálisKérdések[MegjelenítettKérdésszám]);

        }

        void KérdésMegjelenítése(Kerdes kerdes)
        {
            label1.Text = kerdes.KérdésSzöveg;
            textBox1.Text = kerdes.Válasz1;
            textBox2.Text = kerdes.Válasz2;
            textBox3.Text = kerdes.Válasz3;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;

            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3 .BackColor = Color.White;

        }

        List<Kerdes> KérdésekBeolvasása()
        {
            List<Kerdes> kérdések = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {


                string? sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                Kerdes k = new();
                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3].Trim('"');
                k.Válasz3 = tömb[4].Trim('"');
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);

                k.HelyesVálasz = x;


                kérdések.Add(k);
            }
            sr.Close();
            return kérdések;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenítettKérdésszám++;
            if (MegjelenítettKérdésszám == AktuálisKérdések.Count) MegjelenítettKérdésszám = 0;

            KérdésMegjelenítése(AktuálisKérdések[MegjelenítettKérdésszám]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            if (AktuálisKérdések[MegjelenítettKérdésszám].HelyesVálasz == 1)
            {
                textBox1 .BackColor = Color.LightGreen;

            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            if (AktuálisKérdések[MegjelenítettKérdésszám].HelyesVálasz == 1)
            {
                textBox3.BackColor = Color.LightGreen;
                AktuálisKérdések[MegjelenítettKérdésszám].HelyesVálasz++;

            }
            else
            {
               textBox1.BackColor = Color.Salmon;
                AktuálisKérdések[MegjelenítettKérdésszám].HelyesVálasz = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            if (AktuálisKérdések[MegjelenítettKérdésszám].HelyesVálasz == 1)
            {
                textBox2.BackColor = Color.LightGreen;
            }
        }
    }
}