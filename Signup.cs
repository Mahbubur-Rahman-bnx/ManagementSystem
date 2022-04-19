using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Signup : Form
    {
        Login l1 = null;
        public Signup()
        {
            InitializeComponent();
        }
        public Signup(Login l1)
        {
            this.l1 = l1;
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this.Hide();
            l1.Show();
        }

        bool validName()
        {
            if(textBoxName.Text.Trim() == "")
            {
                lblMessage.Text = "Invalid Name!";
                lblMessage.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        bool validPhone()
        {
            if (Regex.IsMatch(textBoxPhone.Text.Trim(), @"^\d{11,11}$"))
            {
                // check already exist in db

                return true;
            }
                
            else
            {
                lblMessage.Text = "Invalid Phone!";
                lblMessage.Visible = true;
                return false;
            }

        }

        bool validEmail()
        {
            if (Regex.IsMatch(textBoxEmail.Text.Trim(), @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                // check already exist in db

                return true;
            }
            else
            {
                lblMessage.Text = "Invalid Email!";
                lblMessage.Visible = true;
                return false;
            }

        }

        bool validPassword()
        {
            if (Regex.IsMatch(textBoxPassword.Text.Trim(), @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                if (textBoxPassword.Text.Trim().Equals(textBoxCPassword.Text.Trim())) return true;
                else
                {
                    lblMessage.Text = "Confirm password didn't match!";
                    lblMessage.ForeColor = Color.Red;
                    return false;
                }
                
            }
            else
            {
                lblMessage.Text = "At least one upper case, lower case, digit, special character and Minimum length 8";
                lblMessage.Visible = true;
                return false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(validName() && validPhone() && validEmail() && validPassword())
            {
                //save to db

                this.Dispose();
                //this.Hide();
                l1.Show();
            }

        } 
    }
}
