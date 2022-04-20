
namespace ManagementSystem
{
    partial class Admin_Task_Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.btnInsertItem = new System.Windows.Forms.Button();
            this.btnItemList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 381);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.listView1);
            this.panelList.Location = new System.Drawing.Point(192, 22);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(573, 388);
            this.panelList.TabIndex = 1;
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Location = new System.Drawing.Point(26, 62);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(136, 29);
            this.btnInsertItem.TabIndex = 2;
            this.btnInsertItem.Text = "Insert new Item";
            this.btnInsertItem.UseVisualStyleBackColor = true;
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // btnItemList
            // 
            this.btnItemList.Location = new System.Drawing.Point(50, 121);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Size = new System.Drawing.Size(94, 29);
            this.btnItemList.TabIndex = 3;
            this.btnItemList.Text = "Items List";
            this.btnItemList.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 154);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Admin_Task_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItemList);
            this.Controls.Add(this.btnInsertItem);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.btnLogout);
            this.Name = "Admin_Task_Board";
            this.Text = "Admin_Task_Board";
            this.panelList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.Button btnItemList;
    }
}