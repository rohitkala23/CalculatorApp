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


namespace Calculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }



        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-J8AI3TS8;Initial Catalog=Calculator;Integrated Security=True");

       


        private void button1_Click(object sender, EventArgs e)
        {
            /*string UserName, Password;
            UserName= txtUserName.Text;
            Password= txtPassword.Text;
            */

            MessageBox.Show(txtUserName.Text + txtPassword.Text);
            try
            {
                String Querry = "SELECT * FROM Credentials WHERE User_Id = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'" ;
                SqlDataAdapter sda = new SqlDataAdapter(Querry,conn);

                conn.Open();
                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if(dTable.Rows.Count == 1 )
                {
                    /*UserName = txtUserName.Text;
                    Password = txtPassword.Text;
                   */
                    new MenuBar().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password entered is incorrect.");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }

            catch 
            {
                MessageBox.Show("Error");
            }

            finally 
            {
                conn.Close();           
            }
            
            
            
            
            /*
            
            
            List<string> Author = new List<string>(); // list of Users
            Author.Add("Rohit");
            Author.Add("Ayush");

            List<string> Passw = new List<string>(); // list of Users
            Passw.Add("kala");
            Passw.Add("rajput");
            //Passw.Contains(txtPassword.Text)

            if (Author.Contains(txtUserName.Text) && Passw.Contains(txtPassword.Text))
            {
                //new CalculatorApp().Show();
                new MenuBar().Show();
                this.Hide();
                
            }

            //if (txtUserName.Text == "rohitkala" && txtPassword.Text == "kala")
            //{
            //  new CalculatorApp().Show();
            // this.Hide();
            //}

            else
            {
                MessageBox.Show("The Username or Password entered is incorrect.");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

            }

            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
