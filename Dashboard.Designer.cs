
namespace ManagementSystem
{
    partial class Dashboard
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
            this.labelName = new System.Windows.Forms.Label();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnLogou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(39, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(39, 78);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(94, 29);
            this.btnOrderList.TabIndex = 1;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.UseWaitCursor = true;
            // 
            // btnLogou
            // 
            this.btnLogou.Location = new System.Drawing.Point(39, 125);
            this.btnLogou.Name = "btnLogou";
            this.btnLogou.Size = new System.Drawing.Size(94, 29);
            this.btnLogou.TabIndex = 2;
            this.btnLogou.Text = "Logout";
            this.btnLogou.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogou);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.labelName);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnLogou;
    }
}