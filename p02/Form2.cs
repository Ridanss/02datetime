using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime birth = dateTimePicker1.Value;
            int roky = dt.Year-birth.Year;
            int mesice = dt.Month - birth.Month;
            if (dt.Day < birth.Day)
            {
                mesice--;
            }
            if (mesice < 0)
            {
                roky--;
                mesice += 12;
            }

            int dny = (dt - birth.AddMonths((roky * 12) + mesice)).Days;
            int hodiny = dt.Hour;

            labelAge.Text = string.Format($"Věk je {roky} let {mesice} měsíců {dny} dnů a {hodiny} hodin");
        }
    }
}
