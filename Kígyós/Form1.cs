namespace Kígyós
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int hossz = 5;
        int lépésszám = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kígyóelem>kígyó = new List<Kígyóelem);


            
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;


            fej_x += irány_x * Kígyóelem.Méret;
            fej_y += irány_y * Kígyóelem.Méret;
            Kígyóelem= new Kígyóelem();
            kígyó.Add(ke);

            foreach (Kígyóelem item in Controls)
            {
                
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    Application.Exit();
                }
            }

            Kígyóelem ke = new Kígyóelem();
            
            Controls.Add(ke);

            if (Controls.Count > hossz) Controls.RemoveAt(0);
            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Up)
                {
                    irány_y = -1;
                    irány_x = 0;
                }

                if (e.KeyCode == Keys.Down)
                {
                    irány_y = 1;
                    irány_x = 0;
                }

                if (e.KeyCode == Keys.Left)
                {
                    irány_y = 0;
                    irány_x = -1;
                }

                if (e.KeyCode == Keys.Right)
                {
                    irány_y = 0;
                    irány_x = 1;
                }
            }
        }
    }
}