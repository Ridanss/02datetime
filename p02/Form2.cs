using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            TimeSpan age = dt - birth;
            if ()
            int year = age.TotalDays/365
            int month = dt.Month - birth.Month;

            labelAge.Text = string.Format($"Věk je ");
        }
    }
}
