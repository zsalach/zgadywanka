using System;
using System.Drawing;
using ModelGry;
using System.Windows.Forms;

namespace GraGraficznie
{
    public partial class Form1 : Form
    {

        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPrzerwij.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLosowanie_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            g = new Gra(a, b);
            labelKomunikat1.Text = $"Wylosowano liczbę od {a} do {b}";
            groupBox1.Enabled = false;
            groupBox2Propozycja.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
            var odp = g.Odpowiedz(propozycja);

            switch (odp)
            {
                case Odp.ZaMalo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za mało";
                    break;
                case Odp.ZaDuzo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za Dużo";
                    break;
                case Odp.Trafiono:
                    labelOdpowiedz.ForeColor = Color.Green;
                    labelOdpowiedz.Text = "Trafiono";
                    groupBox2Propozycja.Enabled = false;
                    buttonPrzerwij.Enabled = false;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int wynik = 0;
            if (int.TryParse(textBox1.Text, out wynik))
                textBox1.BackColor = Color.LightGray;
            else

                textBox1.BackColor = Color.PaleVioletRed;
            ButtonLosowanie.Enabled = false;

        }
    }
}
