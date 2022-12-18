using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linnut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Muuttolintu m1;
        Lintukokoelma lk = new Lintukokoelma();
        private void button1_Click(object sender, EventArgs e)
        {
            m1 = new Muuttolintu();
            String nimi = textBox1.Text;
            string maa = textBox2.Text;
            m1.laitaKaikkitiedot(nimi, maa);

            label1.Text = "Muuttolintu luotu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stringiin tulee kyllä rivinvaihto, mutta sitten comboboxissa linnut tulee yhteen
            // samalle riville. Mitenköhän tuon saisi korjattua? Tietysti comboboxiin voisi
            // laittaa aina suoraan .Items.Addilla uuden linnun luonnin yhteydessä ja
            // lista vastaisi siten samaa sisältöä mikä tulee listaan. Tai sitten minulla on tässä vain joku
            // väärin.
            comboBox1.Items.Add(lk.palautaLinnut());
        }

        Pesa p1;
        private void button3_Click(object sender, EventArgs e)
        {
            p1 = new Pesa();

            label2.Text = "Pesä luotu";
        }
        Raaka_aine ra1, ra2, ra3;
        private void button4_Click(object sender, EventArgs e)
        {
            ra1 = new Raaka_aine();
            ra2 = new Raaka_aine();
            ra3 = new Raaka_aine();
            
            label3.Text = "Raaka-aineet luotu";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            String aineenNimi1 = textBox4.Text;
            String aineenNimi2 = textBox5.Text;
            String aineenNimi3 = textBox6.Text;

            ra1.laitaTiedot(aineenNimi1);
            ra2.laitaTiedot(aineenNimi2);
            ra3.laitaTiedot(aineenNimi3);

            p1.laitaRaakaAineet(ra1, ra2, ra3);
            label4.Text = "Pesälle laitettu raaka-aineet";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            String sijainti = textBox3.Text;
            p1.laitaSij(sijainti);
            m1.laitaPesa(p1);

            label5.Text = "Pesä laitettu linnulle";
        }
        Muuttomaa maa;
        private void button7_Click(object sender, EventArgs e)
        {
            maa = new Muuttomaa();

            label6.Text = "Muuttomaa luotu";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            String muuttomaa = textBox7.Text;
            maa.laitaMaa(muuttomaa);
            m1.laitaMuuttomaa(maa);

            label7.Text = "Muuttomaa laitettu";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = m1.tulostakaikkiTiedot(); 
        }
        private void button11_Click(object sender, EventArgs e)
        {
            String nimi = m1.palautaNimi();
            String path = "C:\\Users\\sakus\\source\\repos\\Linnut\\Linnut\\" + nimi + ".jpg";

            pictureBox1.Image = Image.FromFile(path);

            SoundPlayer sp1 = new SoundPlayer("C:\\Users\\sakus\\source\\repos\\Linnut\\Linnut\\" + nimi + ".wav");
            sp1.Play();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            lk.laitaLintu(m1);
            MessageBox.Show("Tiedot tallennettu");
        }
    }
}
