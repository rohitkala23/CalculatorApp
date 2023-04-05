using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Resources
{
    public partial class MenuBar : Form
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalculatorApp().Show();
            this.Hide();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeDetails().Show();
            this.Hide();
        }
    }
}
