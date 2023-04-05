using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calculator.Resources
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.calculatorDataSet.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getButton_Click(object sender, EventArgs e)
        {
            int lexe;
            string ConnectionString = "Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            string query = "SELECT * FROM Employee;";

            SqlCommand comm = new SqlCommand(query, conn);

            lexe = comm.ExecuteNonQuery();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            new EmployeeDetailsNew().Show();
            this.Hide();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            new EmployeeDetailsNew().Show();
            this.Hide();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.calculatorDataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
