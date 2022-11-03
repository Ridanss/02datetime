using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "90/90/0000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000000\\/0009";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelReport.Text = "report: ";
            labelBirth.Text = "datum narození: ";
            labelAge.Text = "věk: ";
            if (radioButton1.Checked)
            {
                if (JeDatum(maskedTextBox1.Text, out DateTime birth, out string report))
                {
                    labelBirth.Text += birth.ToString("D");
                    labelAge.Text += string.Format($"{Vek(birth, out int days)} let a {days} dní");
                    labelReport.Text += report;
                }
                else labelReport.Text += report;
            }
            else
            {
                
            }

        }
        public bool JeDatum(string datum, out DateTime narozen, out string zprava)
        {
            zprava = "Správné datum narození.";
            narozen = new DateTime();

            if (!maskedTextBox1.MaskCompleted)
            {
                zprava = "Datum narození není vyplněno.";
                return false;
            }

            string den = datum.Substring(0, 2);
            string mes = datum.Substring(3, 2);
            string rok = datum.Substring(6, 4);
            int rokc = Int32.Parse(rok);
            int mesc = Int32.Parse(mes);
            int denc = Int32.Parse(den);

            if (mesc < 1 || mesc > 12)
            {
                zprava = "Špatný měsíc.";
                return false;
            }
            int pocetdni = DateTime.DaysInMonth(rokc, mesc);
            if (denc < 1 || denc > pocetdni)
            {
                zprava = "Špatný den.";
                return false;
            }

            narozen = Convert.ToDateTime(datum);
            return true;
        }

        /*public bool JeRodneCislo(string rcislo,out DateTime narozen, out string zprava)
        {
            zprava = "Rodné číslo je správné.";
            narozen= new DateTime();

            if (!maskedTextBox1.MaskCompleted)
            {
                zprava = "Rodné číslo není vyplněno.";
                return false;
            }

            string rok = rcislo.Substring(0, 2);
            string mes = rcislo.Substring(2, 2);
            string den = rcislo.Substring(4, 2);
            string symbol = rcislo.Substring(7, 4);

            int rokc = Int32.Parse(rok);
            int mesc = Int32.Parse(mes);
            int denc = Int32.Parse(den);
            int symbolc = Int32.Parse(symbol);
            Int64 cislo = Int64.Parse(rcislo.Substring(0, 6));
            if (cislo % 11 == 0)
            {
                zprava = "Špatné rodné číslo.";
                return false;
            }

            

        }*/

        public int Vek(DateTime birth,out int days)
        {
            DateTime dt = DateTime.Now;
            int roky = dt.Year - birth.Year;
            if (birth.DayOfYear > dt.DayOfYear) roky--;
            days = (dt - birth).Days;
            return roky;
        }
    }
}
