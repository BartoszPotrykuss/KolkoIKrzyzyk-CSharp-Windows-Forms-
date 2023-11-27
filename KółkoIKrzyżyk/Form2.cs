using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KółkoIKrzyżyk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Boolean gracz = true;
        Boolean kolko1, kolko2, kolko3, kolko4, kolko5, kolko6, kolko7, kolko8, kolko9;
        Boolean krzyzyk1, krzyzyk2, krzyzyk3, krzyzyk4, krzyzyk5, krzyzyk6, krzyzyk7, krzyzyk8, krzyzyk9;
        int WSZkolko, WSZremis, WSZkrzyzyk;
        string punktSerialized;

        private void label4_TextChanged(object sender, EventArgs e)
        {
            WSZkrzyzyk++;
            labelWSZkrzyzyk.Text = WSZkrzyzyk.ToString();
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            WSZremis++;
            labelWSZremis.Text = WSZremis.ToString();
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            WSZkolko++;
            labelWSZkolko.Text = WSZkolko.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            punktSerialized = File.ReadAllText(@"punktSerialized.json");
            wszeczasyPunkt punkt = JsonConvert.DeserializeObject<wszeczasyPunkt>(punktSerialized);
            WSZkolko = punkt.kolko;
            WSZkrzyzyk = punkt.krzyzyk;
            WSZremis = punkt.remis;
            labelWSZkolko.Text = punkt.kolko.ToString();
            labelWSZkrzyzyk.Text = punkt.krzyzyk.ToString();
            labelWSZremis.Text= punkt.remis.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wszeczasyPunkt punkt = new wszeczasyPunkt(WSZkolko, WSZremis, WSZkrzyzyk);
            punktSerialized = JsonConvert.SerializeObject(punkt);
            File.WriteAllText(@"punktSerialized.json", punktSerialized);

            Application.Exit();
        }

        int licznikKolka, licznikKrzyzyka, licznikRemisow;
        private void button1_Click(object sender, EventArgs e)
        {
            wszeczasyPunkt punkt = new wszeczasyPunkt(WSZkolko, WSZremis, WSZkrzyzyk);
            punktSerialized = JsonConvert.SerializeObject(punkt);
            File.WriteAllText(@"punktSerialized.json", punktSerialized);

            Application.Restart();
        }

        public void zmianaGracza()
        {
            if (gracz) gracz = false;
            else gracz = true;
        }

        public void sprawdzCzywygrana()
        {
            if (kolko1 && kolko2 && kolko3 || kolko1 && kolko4 && kolko7 || kolko1 && kolko5 && kolko9 || kolko7 && kolko8 && kolko9 
                || kolko3 && kolko6 && kolko9 || kolko3 && kolko5 && kolko7 || kolko2 && kolko5 && kolko8 || kolko4 && kolko5 && kolko6)
            {
                MessageBox.Show("Kółko wygrało");
                licznikKolka++;
                label3.Text = Convert.ToString(licznikKolka);
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                kolko1 = false;
                kolko2 = false;
                kolko3 = false;
                kolko4 = false;
                kolko5 = false;
                kolko6 = false;
                kolko7 = false;
                kolko8 = false;
                kolko9 = false;
                krzyzyk1 = false;
                krzyzyk2 = false;
                krzyzyk3 = false;
                krzyzyk4 = false;
                krzyzyk5 = false;
                krzyzyk6 = false;
                krzyzyk7 = false;
                krzyzyk8 = false;
                krzyzyk9 = false;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
            }
            else if (krzyzyk1 && krzyzyk2 && krzyzyk3 || krzyzyk1 && krzyzyk4 && krzyzyk7 || krzyzyk1 && krzyzyk5 && krzyzyk9 || 
                krzyzyk7 && krzyzyk8 && krzyzyk9|| krzyzyk3 && krzyzyk6 && krzyzyk9 || krzyzyk3 && krzyzyk5 && krzyzyk7 ||
                krzyzyk2 && krzyzyk5 && krzyzyk8 || krzyzyk4 && krzyzyk5 && krzyzyk6)
            {
                MessageBox.Show("Krzyżyk wygrał");
                licznikKrzyzyka++;
                label4.Text = Convert.ToString(licznikKrzyzyka);
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                kolko1 = false;
                kolko2 = false;
                kolko3 = false;
                kolko4 = false;
                kolko5 = false;
                kolko6 = false;
                kolko7 = false;
                kolko8 = false;
                kolko9 = false;
                krzyzyk1 = false;
                krzyzyk2 = false;
                krzyzyk3 = false;
                krzyzyk4 = false;
                krzyzyk5 = false;
                krzyzyk6 = false;
                krzyzyk7 = false;
                krzyzyk8 = false;
                krzyzyk9 = false;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
            }
            else if ((kolko1 || krzyzyk1) && (kolko2 || krzyzyk2) && (kolko3 || krzyzyk3) && (kolko4 || krzyzyk4) && (kolko5 || krzyzyk5) &&
                (kolko6 || krzyzyk6) && (kolko7 || krzyzyk7) && (kolko8 || krzyzyk8) && (kolko9 || krzyzyk9))
            {
                MessageBox.Show("Remis");
                licznikRemisow++;
                label5.Text = Convert.ToString(licznikRemisow);
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                kolko1 = false;
                kolko2 = false;
                kolko3 = false;
                kolko4 = false;
                kolko5 = false;
                kolko6 = false;
                kolko7 = false;
                kolko8 = false;
                kolko9 = false;
                krzyzyk1 = false;
                krzyzyk2 = false;
                krzyzyk3 = false;
                krzyzyk4 = false;
                krzyzyk5 = false;
                krzyzyk6 = false;
                krzyzyk7 = false;
                krzyzyk8 = false;
                krzyzyk9 = false;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox1.Image = Properties.Resources.krzyzyk;
                krzyzyk1 = true;
                label2.ForeColor = Color.Blue;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.kółko;
                kolko1 = true;
            }
            zmianaGracza();
            pictureBox1.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox2.Image = Properties.Resources.krzyzyk;
                krzyzyk2 = true;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.kółko;
                kolko2 = true;
            }
                zmianaGracza();
            pictureBox2.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox3.Image = Properties.Resources.krzyzyk;
                krzyzyk3 = true;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.kółko;
                kolko3 = true;
            }
            zmianaGracza();
            
            pictureBox3.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox4.Image = Properties.Resources.krzyzyk;
                krzyzyk4 = true;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.kółko;
                kolko4 = true;
            }
            zmianaGracza();
            pictureBox4.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox5.Image = Properties.Resources.krzyzyk;
                krzyzyk5 = true;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.kółko;
                kolko5 = true;
            }
            zmianaGracza();
            pictureBox5.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox6.Image = Properties.Resources.krzyzyk;
                krzyzyk6 = true;
            }
            else
            {
                pictureBox6.Image = Properties.Resources.kółko;
                kolko6 = true;
            }
            zmianaGracza();
            pictureBox6.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox7.Image = Properties.Resources.krzyzyk;
                krzyzyk7 = true;
            }
            else
            { 
                pictureBox7.Image = Properties.Resources.kółko;
                kolko7 = true;
            }
            zmianaGracza();
            pictureBox7.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox8.Image = Properties.Resources.krzyzyk;
                krzyzyk8 = true;
            }
            else
            {
                pictureBox8.Image = Properties.Resources.kółko;
                kolko8 = true;
            }
            zmianaGracza();
            pictureBox8.Enabled = false;
            sprawdzCzywygrana();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (gracz == true)
            {
                pictureBox9.Image = Properties.Resources.krzyzyk;
                krzyzyk9 = true;
            }
            else
            {
                pictureBox9.Image = Properties.Resources.kółko;
                kolko9 = true;
            }
            zmianaGracza();
            pictureBox9.Enabled = false;
            sprawdzCzywygrana();
        }
    }
}
