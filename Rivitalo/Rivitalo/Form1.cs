using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rivitalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Rivitalo rt = new Rivitalo();
        Huoltoyhtio hy = new Huoltoyhtio();
        Tyontekija t1;
        Huoneisto h1, h2, h3;
        Omistaja o1 = new Omistaja();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hy.laitaTyontekijat();

            foreach (string line in hy.palautaTyontekijat().Split('\n'))
                comboBox1.Items.Add(line);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            h1 = new Huoneisto();
            int hmaara = Convert.ToInt16(textBox4.Text);
            int kpala = Convert.ToInt16(textBox5.Text);
            h1.laitaHmaara(hmaara);
            h1.laitaKpala(kpala);

            textBox4.Text = "";
            textBox5.Text = "";

            label9.Text = "Huoneisto 1 luotu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Tyontekija();
            int sv = Convert.ToInt16(textBox3.Text);
            String nimi = textBox1.Text;
            String fk = textBox2.Text;

            t1.laitaKaikkitiedot(nimi, fk, sv);
            label8.Text = "Työntekijä luotu";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h2 = new Huoneisto();
            int hmaara = Convert.ToInt16(textBox4.Text);
            int kpala = Convert.ToInt16(textBox5.Text);
            h2.laitaHmaara(hmaara);
            h2.laitaKpala(kpala);

            textBox4.Text = "";
            textBox5.Text = "";

            label10.Text = "Huoneisto 2 luotu";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            h3 = new Huoneisto();
            int hmaara = Convert.ToInt16(textBox4.Text);
            int kpala = Convert.ToInt16(textBox5.Text);
            h3.laitaHmaara(hmaara);
            h3.laitaKpala(kpala);

            textBox4.Text = "";
            textBox5.Text = "";

            label11.Text = "Huoneisto 3 luotu";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String teksti = "Huoneiden määrä: " + h1.palautaHmaara() + "\n" + "Kokonaispinta-ala: " + h2.palautaKpala() + "\n" + "Huoneiden määrä: " + h2.palautaHmaara() + "\n" + "Kokonaispinta-ala: " + h2.palautaKpala() + "\n" + "Huoneiden määrä: " + h3.palautaHmaara() + "\n" + "Kokonaispinta-ala: " + h3.palautaKpala() + "\n";
            //listBox2.Items.Add(teksti);

            foreach (string line in teksti.Split('\n'))
                listBox2.Items.Add(line);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tähän jäi kun aika loppuu :'(
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hy.laitaTyontekija(t1);
            comboBox1.Items.Clear();

            foreach (string line in hy.palautaTyontekijat().Split('\n'))
                comboBox1.Items.Add(line);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String paikka = comboBox1.Text;
            listBox1.Items.Clear();

            foreach (string line in hy.palautaTyontekijatiedot(hy.palautaPaikka(paikka)).Split('\n'))
                listBox1.Items.Add(line);
        }
    }
}
