using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p07
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        DateTime beginning;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelHour.Text = "ČAS\nHod: ";
            labelMinutes.Text = "Min: ";
            labelSeconds.Text = "Sek: ";
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
            beginning = DateTime.Now;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            DateTime end = DateTime.Now;
            TimeSpan daycount = end - beginning;
            labelHour.Text += daycount.Hours;
            labelMinutes.Text += daycount.Minutes;
            labelSeconds.Text += daycount.TotalSeconds;
        }
    }
}
