using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            MessageBox.Show(String.Format($"Dnes je {dt:D}. Je to {dt.DayOfYear}. den v roce. Je {dt.Hour} hodin {dt.Minute} minut a {dt.Second} sekund"));
        }
    }
}
