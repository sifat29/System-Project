namespace Tiny_Library_Book_Store_Management_System
{
    partial class Users_Form
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
            this.login_As = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // login_As
            // 
            this.login_As.AutoSize = true;
            this.login_As.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_As.Location = new System.Drawing.Point(15, 20);
            this.login_As.Name = "login_As";
            this.login_As.Size = new System.Drawing.Size(92, 24);
            this.login_As.TabIndex = 0;
            this.login_As.Text = "Login As";
            // 
            // Manager
            // 
            this.Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager.Location = new System.Drawing.Point(386, 285);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(115, 34);
            this.Manager.TabIndex = 3;
            this.Manager.Text = "Manager";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Admin.Location = new System.Drawing.Point(92, 285);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(118, 34);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Tiny_Library_Book_Store_Management_System.Properties.Resources.manager1;
            this.panel2.Location = new System.Drawing.Point(345, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 181);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tiny_Library_Book_Store_Management_System.Properties.Resources.admin1;
            this.panel1.Location = new System.Drawing.Point(64, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 181);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(652, 429);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_As);
            this.Name = "Users_Form";
            this.Text = "Users Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_As;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Manager;
        private System.Windows.Forms.Button Admin;
    }
}

