using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            string day = Convert.ToString(dt.DayOfWeek);
            switch (day)
            {
                case "Monday": MessageBox.Show("Je první pracovní den");
                    break;
                case "Tuesday":
                case "Wednesday":
                case "Thursday": MessageBox.Show("Není první ani poslední pracovní den");
                    break;
                case "Friday": MessageBox.Show("Je poslední pracovní den");
                    break;
                case "Saturday":
                case "Sunday": MessageBox.Show("Je víkend");
                    break;
            }
        }
    }
}
