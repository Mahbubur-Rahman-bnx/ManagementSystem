using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private bool validEmail()
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

        private bool validPassword()
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
                    //System.Diagnostics.Debug.WriteLine("ok db");
                    try
                    {
                        
                            System.Diagnostics.Debug.WriteLine("ok db");

                            using (SqlConnection con = new SqlConnection(CommonClass.strcon))
                            {

                                using (SqlCommand cmd = new SqlCommand())
                                {
                                    string qur = "select id,name,phone,email from users where email='" +
                                        txtEmail.Text.ToString().Trim() +
                                        "' and password ='" +
                                        txtPassword.Text.ToString().Trim() +
                                        "'";

                                    System.Diagnostics.Debug.WriteLine(qur);
                                    con.Open();
                                    cmd.CommandText = qur;
                                    cmd.Connection = con;


                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        if (dr.HasRows)
                                        {
                                            while (dr.Read())
                                            {
                                                CommonClass.currentUserId = dr.GetValue(0).ToString();
                                                CommonClass.currentUserName = dr.GetValue(1).ToString();
                                                CommonClass.currentUserPhone = dr.GetValue(2).ToString();
                                                CommonClass.currentUserEmail = dr.GetValue(3).ToString();

                                        if (CommonClass.currentUserEmail == "admin@gmail.com")
                                        {
                                            this.Hide();
                                            Admin_Insert ad1 = new Admin_Insert();
                                            ad1.Show();
                                        }
                                        else
                                        {
                                            this.Hide();
                                            Dashboard d1 = new Dashboard();
                                            d1.Show();
                                        }
                                    }
                                        }
                                        else
                                        {
                                            // no user found
                                            MessageBox.Show("no user found");
                                            lblMessage.Text = "no user found";
                                            lblMessage.Visible = true;
                                        }


                                    }

                                }

                            }
                        
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex);
                    }

                

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
