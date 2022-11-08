using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p08
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public static bool ZarukaRoky(DateTime bought, int years, out int timeleft)
        {
            DateTime today = DateTime.Today;

            TimeSpan left = today - (bought.AddYears(years));
            timeleft = left.Days;
            if (timeleft < 0)
            {
                timeleft *= -1;
                return true;
            }
            return false;

        }
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text,out int let))
            {
                labelInsurance.Text = "záruka: ";
                DateTime bought = dateTimePicker1.Value;
                bool zaruka = ZarukaRoky(bought, let, out int zbyva);
                if (zaruka) labelInsurance.Text += "Zbývá " + zbyva + " dní";
                else labelInsurance.Text += "Vypršela";
            }

        }
    }
}
