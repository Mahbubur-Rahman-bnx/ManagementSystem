using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool validEmail()
        {
            if (Regex.IsMatch(txtEmail.Text.Trim(), @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                return true;
            else
            {
                lblMessage.Text = "Invalid Email!";
                lblMessage.Visible = true;
                return false;
            }

        }

        bool validPassword()
        {
            if (Regex.IsMatch(txtPassword.Text.Trim(), @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                return true;
            }

            else
            {
                lblMessage.Text = "At least one upper case, lower case, digit, special character and Minimum length 8";
                lblMessage.Visible = true;           
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validEmail() && validPassword())
            {
                lblMessage.Text = "";
                lblMessage.Visible = false;
                System.Diagnostics.Debug.WriteLine(txtEmail.Text.ToString());

                // add db here
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s1 = new Signup(this);
            s1.Show();
        }
    }
}
