using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antikvariaatti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Antikvariaatti ak = new Antikvariaatti();
        Omistaja o1 = new Omistaja();
        Kirja k1;
        private void button1_Click(object sender, EventArgs e)
        {
           k1 = new Kirja();
           int sivut = Convert.ToInt16(textBox2.Text);
           String nimi = textBox1.Text;
           String kirjailija = textBox3.Text;
           String sposti = textBox6.Text;

            if (Convert.ToInt16(textBox2.Text) > 9 && Convert.ToInt16(textBox2.Text) <= 2000 && sposti.Contains("@") == true)
            {
                k1.laitaKaikkitiedot(nimi, sivut, new Kirjoittaja(kirjailija, sposti));
                label1.Text = "Kirja luotu";
            }
            else label1.Text = "Tarkista sivumäärä ja kirjoittajan sähköpostiosoite!";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ak.laitaKirja(k1);
            comboBox1.Items.Clear();

            foreach (string line in ak.palautaKirjat().Split('\n'))
                comboBox1.Items.Add(line);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ak.laitaKirjat();

            foreach (string line in ak.palautaKirjat().Split('\n'))
                comboBox1.Items.Add(line);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            String nimi = textBox7.Text;
            String puhnro = textBox8.Text;

            // Jos laitetaan "040-" eteen niin pitää olla yli 4 + 6 = 10
            if (puhnro.Length > 10)
            {
                o1.laitaNimi(nimi);
                o1.laitaPuhnro(puhnro);
                String omistaja = o1.palautaNimi() + "n antikvariaatti - Puh. " + o1.palautaPuhnro();
                this.Text = omistaja;
                label9.Text = "Omistaja luotu";
            }
            else label9.Text = "Tarkista puhelinnumeron pituus!";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String paikka = comboBox1.Text;
            ak.kirjahylly.RemoveAt(ak.palautaPaikka(paikka));

            comboBox1.Items.Clear();

            foreach (string line in ak.palautaKirjat().Split('\n'))
                comboBox1.Items.Add(line);

            comboBox1.Text = "";
            label10.Text = "Kirja poistettu hyllystä";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String paikka = comboBox1.Text;
            listBox1.Items.Clear();

            foreach (string line in ak.palautaKirjatiedot(ak.palautaPaikka(paikka)).Split('\n'))
                listBox1.Items.Add(line);
        }
    }
}
