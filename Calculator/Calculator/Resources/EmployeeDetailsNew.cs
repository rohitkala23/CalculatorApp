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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator.Resources
{
    public partial class EmployeeDetailsNew : Form
    {
        public EmployeeDetailsNew()
        {
            InitializeComponent();
        }

        private void EmployeeDetailsNew_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int lexe;
            string ConnectionString = "Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();
            string query = "INSERT INTO Employee ( Emp_Id, Name, FirstName, MiddleName, LastName,Address,Zip,State,Country,Role,PhoneNumber,Email_Id)" + "VALUES(NEXT VALUE FOR EmpSequence,'" + nametextBox.Text.TrimStart() + "','" + FirstNametextBox.Text.TrimStart() + "','" + MiddleNametextBox.Text.TrimStart() + "','" + LastNametextBox.Text.TrimStart() + "','" +addresstextBox.Text.TrimStart() + "','" + textBox8.Text.TrimStart() + "','" + textBox9.Text.TrimStart() + "','" + textBox10.Text.TrimStart() + "','" + textBox11.Text.TrimStart() + "','" + textBox3.Text.TrimStart() + "','" + textBox12.Text.TrimStart() +"');";

            SqlCommand comm = new SqlCommand(query, conn);

            lexe = comm.ExecuteNonQuery();

            conn.Close();

            new EmployeeDetails().Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lexe;
            string ConnectionString = "Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            string query = "SELECT * FROM Employee WHERE Emp_Id = '" + Emp_IdTextBox.Text + "'";

            SqlCommand comm = new SqlCommand(query, conn);

            lexe = comm.ExecuteNonQuery();
            var reader = comm.ExecuteReader();

            if(reader.Read())
            {
                nametextBox.Text = reader["Name"].ToString();
                FirstNametextBox.Text = reader["FirstName"].ToString();
                MiddleNametextBox.Text = reader["MiddleName"].ToString();
                LastNametextBox.Text = reader["LastName"].ToString();
                addresstextBox.Text = reader["Address"].ToString();
                textBox8.Text = reader["Zip"].ToString();
                textBox9.Text = reader["State"].ToString();
                textBox10.Text = reader["Country"].ToString();
                textBox11.Text = reader["Role"].ToString();
                textBox3.Text = reader["PhoneNumber"].ToString();
                textBox12.Text = reader["Email_Id"].ToString();
            }
            else
            {
                MessageBox.Show("No record found.");
            }

            conn.Close();  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int lexe;
            string ConnectionString = "Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();
            string query = "UPDATE Employee set Name = '" + nametextBox.Text.TrimStart() + "', FirstName = '" + FirstNametextBox.Text.TrimStart() + "', MiddleName = '" + MiddleNametextBox.Text.TrimStart() + "', LastName = '" + LastNametextBox.Text.TrimStart() + "',Address = '" + addresstextBox.Text.TrimStart() + "',Zip = '" + textBox8.Text.TrimStart() + "',State = '" + textBox9.Text.TrimStart() + "',Country = '" + textBox10.Text.TrimStart() + "', Role = '" + textBox11.Text.TrimStart() + "',PhoneNumber = '" + textBox3.Text.TrimStart() + "',Email_Id = '" + textBox12.Text.TrimStart() + "' WHERE Emp_Id = " + Emp_IdTextBox.Text.TrimStart() + ";";

            SqlCommand comm = new SqlCommand(query, conn);

            lexe = comm.ExecuteNonQuery();

            conn.Close();

            new EmployeeDetails().Show();
            this.Hide();
        }
    }
}
