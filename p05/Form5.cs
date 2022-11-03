using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lines = textBox1.Lines.Count();
            DateTime oldest = DateTime.Now;
            int maxI = 0;
            DateTime current;
            string[] person;
            for (int i = 0; i < lines; i++)
            {
                person = textBox1.Lines[i].Split(';');
                current = Convert.ToDateTime(person[2]);
                if (current < oldest)
                {
                    oldest = current;
                    maxI = i;
                }
            }
            MessageBox.Show(textBox1.Lines[maxI].Replace(';', ' ') + " Je nejstarší");
        }
    }
}
