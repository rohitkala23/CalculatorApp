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

        private void button1_Click(object sender, EventArgs e)
        {
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
        }
    }
}
