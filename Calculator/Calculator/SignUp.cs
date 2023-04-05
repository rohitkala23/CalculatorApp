using Calculator.Resources;
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
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int lexe;
            string ConnectionString = "Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();



            var enteredPassword = textPassword.Text;

            if(enteredPassword == "")
            {
                MessageBox.Show("Password should not be empty.");
                return;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperCase = new Regex(@"[A-Z]+");
            var hasLowerCase = new Regex(@"[a-z]+");
            var hasSpecialChar = new Regex(@"[@#]+");

            if (!hasNumber.IsMatch( enteredPassword ))
            {
                MessageBox.Show("Password should conatin atleast one numeric value.");
                return;
            }
            else if (!hasUpperCase.IsMatch(enteredPassword))
            {
                MessageBox.Show("Password should conatin atleast one uppercase letter.");
                return;
            }
            else if (!hasLowerCase.IsMatch(enteredPassword))
            {
                MessageBox.Show("Password should conatin atleast one lowercase letter.");
                return;
            }
            else if (!hasSpecialChar.IsMatch(enteredPassword))
            {
                MessageBox.Show("Password should conatin atleast one symbol among @ or #.");
                return;
            }

            else
            {
                string query = "INSERT INTO Credentials ( Cred_Id, User_Id, Password, SecurityQues, SecurityAns)" + "VALUES(NEXT VALUE FOR CredSequence,'" + textUserName.Text.TrimStart() + "','" + textPassword.Text.TrimStart() + "','" + comboBox2.Text + "', '" + textBox1.Text + "');";

                SqlCommand comm = new SqlCommand(query, conn);

                lexe = comm.ExecuteNonQuery();
            }




            //int lexe;
            //string ConnectionString = "Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True";

            //SqlConnection conn = new SqlConnection(ConnectionString);

            //conn.Open();

            //string query = "INSERT INTO Credentials ( Cred_Id, User_Id, Password, SecurityQues, SecurityAns)" + "VALUES(NEXT VALUE FOR CredSequence,' " + textUserName.Text.TrimStart() + "','" + textPassword.Text.TrimEnd() + "','" + comboBox2.Text + "', '" + textBox1.Text + "');";
           
            //SqlCommand comm = new SqlCommand(query, conn);

            // lexe = comm.ExecuteNonQuery();

            // MessageBox.Show(lexe + "Query");
            // SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Credentials", conn);
            // DataTable sqltab = new DataTable();

            // da.Fill(sqltab);
            // grid.DataSource = sqltab;

            conn.Close();


            new MenuBar().Show();
            this.Hide();
        }
    }
}
