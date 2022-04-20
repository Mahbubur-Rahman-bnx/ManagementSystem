using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Admin_Insert : Form
    {
        Admin_Task_Board ad1;
        public Admin_Insert()
        {
            InitializeComponent();
            itemList();
        }
        public Admin_Insert(Admin_Task_Board ad1)
        {
            this.ad1 = ad1;
            InitializeComponent();
            itemList();
        }

        void itemList()
        {
            try
            {
                SqlConnection con = new SqlConnection(CommonClass.strcon);
                if (con.State == ConnectionState.Closed) con.Open();

                String qur = "select * from Food_Table;";
                SqlCommand cmd = new SqlCommand(qur, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    dataGridView1.DataSource = dt;
                    //lblMessage.Text = "Item Found";
                    lblMessage.Visible = false;
                    
                }

                else
                {
                    lblMessage.Text = "No Item";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login l = new Login();
            l.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.ToString().Trim() != "" &&
               textBoxPrice.Text.ToString().Trim() != "" &&
                    textBoxQuantity.Text.ToString().Trim() != "" )
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine("ok db Insert");

                    if (searchItem(textBoxName.Text.ToString().Trim()))
                    {
                        lblMessage.Text = "Already Inserted";
                        lblMessage.Visible = true;
                        lblMessage.ForeColor = Color.DarkViolet;
                    }
                    else
                    {
                        using (SqlConnection con = new SqlConnection(CommonClass.strcon))
                        {

                            using (SqlCommand cmd = new SqlCommand())
                            {
                                string qur = "insert into Food_Table " +
                                    "(name,price,quantity) values " +
                                    "('" + textBoxName.Text.Trim() +
                                    "','" + textBoxPrice.Text.Trim() +
                                    "'," + textBoxQuantity.Text.Trim() +
                                     ")";

                                System.Diagnostics.Debug.WriteLine(qur);
                                con.Open();
                                cmd.CommandText = qur;
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("New Item inserted.");

                                itemList();
                                textBoxName.Clear();
                                textBoxPrice.Clear();
                                textBoxQuantity.Clear();
                                lblMessage.Visible = false;

                            }

                        }


                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            else
            {
                lblMessage.Text = "Fill all the field!";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text.ToString().Trim() != "" && (textBoxPrice.Text.Trim() != "" || textBoxQuantity.Text.Trim() != ""))
            {
                string p = "0";
                string q = "0";
                    string qur = "if exists(SELECT * from Food_Table where name='" +
                    textBoxName.Text.ToString().Trim() +
                    "')" +
                    " begin " +
                    "Update Food_Table set ";
                if(textBoxPrice.Text.Trim() != "" && textBoxQuantity.Text.Trim() != "")
                {
                    qur += " price = '" + textBoxPrice.Text.Trim() + "' ";
                    qur += " , quantity = " + textBoxQuantity.Text.Trim();
                    p = textBoxPrice.Text.ToString();
                    q = textBoxQuantity.Text.ToString();
                }
                else if (textBoxPrice.Text.Trim() != "")
                {
                    p = textBoxPrice.Text.ToString();
                    qur += " price = '" + textBoxPrice.Text.Trim() + "' ";
                }

                else if (textBoxQuantity.Text.Trim() != "")
                {
                    q = textBoxQuantity.Text.ToString();
                    qur += " quantity = " + textBoxQuantity.Text.Trim();
                }
                qur += " where name = '" + textBoxName.Text.Trim() + "' end ";
                try
                {
                    System.Diagnostics.Debug.WriteLine("ok db update");

                    using (SqlConnection con = new SqlConnection(CommonClass.strcon))
                    {

                        using (SqlCommand cmd = new SqlCommand())
                        {
                             qur += " else begin insert into Food_Table " +
                                "(name,price,quantity) values " +
                                "('" + textBoxName.Text.Trim() +
                                "','" + p +
                                "'," + q +
                                 ") end";

                            System.Diagnostics.Debug.WriteLine(qur);
                            con.Open();
                            cmd.CommandText = qur;
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Item Updated.");
                            itemList();
                            textBoxName.Clear();
                            textBoxPrice.Clear();
                            textBoxQuantity.Clear();
                            lblMessage.Visible = false;

                        }

                    }


                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            else
            {
                lblMessage.Text = "Fill at least one field!";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Visible = true;
            }

        }

        bool searchItem(string name)
        {

            try
            {
                SqlConnection con = new SqlConnection(CommonClass.strcon);
                if (con.State == ConnectionState.Closed) con.Open();

                String qur = "select * from Food_Table where name='" + name + "';";
                SqlCommand cmd = new SqlCommand(qur, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    //lblMessage.Text = "Item Found";
                    //lblMessage.Visible = true;
                    return true;
                }

                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Trim() != "")
            {
                if (searchItem(textBoxName.Text.ToString().Trim()))
                {

                    try
                    {
                        System.Diagnostics.Debug.WriteLine("ok db Delete");

                        using (SqlConnection con = new SqlConnection(CommonClass.strcon))
                        {

                            using (SqlCommand cmd = new SqlCommand())
                            {
                                string qur = "Delete Food_Table where name ='" +
                                    textBoxName.Text.ToString().Trim() +
                                    "'";

                                System.Diagnostics.Debug.WriteLine(qur);
                                con.Open();
                                cmd.CommandText = qur;
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Item Deleted.");
                                itemList();
                                textBoxName.Clear();
                                textBoxPrice.Clear();
                                textBoxQuantity.Clear();
                                lblMessage.Visible = false;

                            }

                        }


                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex);
                    }

                }
                else
                {
                    lblMessage.Text = "No Item Found!";
                    lblMessage.ForeColor = Color.Crimson;
                    lblMessage.Visible = true;
                }
            }
        }
    }
}
