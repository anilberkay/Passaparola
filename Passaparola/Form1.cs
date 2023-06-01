namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            List<Button> buttons = new List<Button>();
            string[] alphabet = { "A", "B ", "C", "Ç", "D", "E", "F", "G", "H", "I", "Ý", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "T", "U", "Ü", "V", "Y", "Z" };

            for (int i = 1; i <= 27; i++)
            {
                Button button = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                if (button != null)
                {
                    buttons.Add(button);
                }
            }

            for (int a = 0; a <= 26; a++)
            {
                buttons[a].Text = Convert.ToString(alphabet[a]);
            }

        }

        int soru = 0, dogru = 0, yanlis = 0, sayac = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            linkLabel1.Text = "Sonraki";
            soru += 1;
            timer1.Start();

            if (soru == 1)
            {
                richTextBox1.Text = "Soru1";
                button1.BackColor = Color.Yellow;
            }

            if (soru == 2)
            {
                richTextBox1.Text = "Soru2";
                button1.BackColor = Color.Yellow;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (linkLabel1.Text == "Sonraki")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBox1.Text == "Cevap")
                    {
                        button1.BackColor = Color.Green;
                        dogru += 1;
                        label2.Text = Convert.ToString(dogru);
                        soru += 1;
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        yanlis += 1;
                        label4.Text = Convert.ToString(yanlis);
                        soru += 1;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            label6.Text =Convert.ToString(sayac);
            if (sayac == 120) 
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti!");
            }
        }
    }
}