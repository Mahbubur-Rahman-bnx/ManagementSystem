using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Admin_Task_Board : Form
    {
        public Admin_Task_Board()
        {
            InitializeComponent();
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Insert ai = new Admin_Insert(this);
            ai.Show();
        }
    }
}
