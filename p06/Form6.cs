using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public static int PocetDni(int year,DateTime birth)
        {
            DateTime today = DateTime.Now;
            birth=birth.AddYears(year);
            TimeSpan daycount = today - birth;
            return daycount.Days;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelDuchod.Text = "Důchod:\n";
            DateTime birth = dateTimePicker1.Value;
            int days = PocetDni(65, birth);

            if (days > 0) labelDuchod.Text += string.Format($"Osoba strávila {days} v důchodu");
            else labelDuchod.Text += string.Format($"Osobě chybí {Math.Abs(days)} dní do důchodu");
        }
    }
}
