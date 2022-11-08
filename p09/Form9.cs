using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p09
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public static bool MinTrvanlivostDny(DateTime bought, int days, out int timeleft)
        {
            DateTime today = DateTime.Today;

            TimeSpan left = today - (bought.AddDays(days));
            timeleft = left.Days;
            
            if (timeleft < 0)
            {
                timeleft *= -1;
                return true;
            }

            timeleft *= -1;
            return false;

        }

        double cena = 250;
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            double cena = double.Parse(textBox2.Text);
            if (int.TryParse(textBox1.Text,out int days))
            {
                labelTrvanlivost.Text = "Trvanlivost: ";
                bool trvan = MinTrvanlivostDny(dateTimePicker1.Value, days, out int zbyva);
            
                if (trvan)
                {
                    labelTrvanlivost.Text += string.Format($"Zýbvá {zbyva} dní trvanlivosti");
                    if (zbyva <= 3)
                    {
                        textBox2.Text = (cena * 0.75).ToString();
                    }
                }
                else
                {
                    zbyva = zbyva * (-1) + 1;
                    labelTrvanlivost.Text += string.Format($"Produkt je {zbyva} dní prošlý");
                    if (zbyva >= 10)
                    {
                        labelTrvanlivost.Text += "Neprodejné";
                    }
                    else if (zbyva >= 0)
                    {
                        textBox2.Text = (cena * 0.5).ToString();
                    }
                }
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cena = double.Parse(textBox2.Text);
        }
    }
}
