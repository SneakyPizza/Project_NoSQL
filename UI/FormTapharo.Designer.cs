
namespace UI
{
    partial class FormTapharo
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
            this.BTNInsertUser = new System.Windows.Forms.Button();
            this.TXTBUsername = new System.Windows.Forms.TextBox();
            this.TXTBPassword = new System.Windows.Forms.TextBox();
            this.TXTBFirstname = new System.Windows.Forms.TextBox();
            this.TXTBLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNDeleteAccess = new System.Windows.Forms.Button();
            this.ListviewUser = new System.Windows.Forms.ListView();
            this.BTNUpdateAccess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_User = new System.Windows.Forms.RadioButton();
            this.RB_Admin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNInsertUser
            // 
            this.BTNInsertUser.Location = new System.Drawing.Point(81, 512);
            this.BTNInsertUser.Name = "BTNInsertUser";
            this.BTNInsertUser.Size = new System.Drawing.Size(112, 34);
            this.BTNInsertUser.TabIndex = 0;
            this.BTNInsertUser.Text = "Add";
            this.BTNInsertUser.UseVisualStyleBackColor = true;
            this.BTNInsertUser.Click += new System.EventHandler(this.BTNInsertUser_Click);
            // 
            // TXTBUsername
            // 
            this.TXTBUsername.Location = new System.Drawing.Point(81, 74);
            this.TXTBUsername.Name = "TXTBUsername";
            this.TXTBUsername.Size = new System.Drawing.Size(150, 31);
            this.TXTBUsername.TabIndex = 1;
            // 
            // TXTBPassword
            // 
            this.TXTBPassword.Location = new System.Drawing.Point(81, 150);
            this.TXTBPassword.Name = "TXTBPassword";
            this.TXTBPassword.Size = new System.Drawing.Size(150, 31);
            this.TXTBPassword.TabIndex = 2;
            // 
            // TXTBFirstname
            // 
            this.TXTBFirstname.Location = new System.Drawing.Point(81, 218);
            this.TXTBFirstname.Name = "TXTBFirstname";
            this.TXTBFirstname.Size = new System.Drawing.Size(150, 31);
            this.TXTBFirstname.TabIndex = 3;
            // 
            // TXTBLastname
            // 
            this.TXTBLastname.Location = new System.Drawing.Point(81, 284);
            this.TXTBLastname.Name = "TXTBLastname";
            this.TXTBLastname.Size = new System.Drawing.Size(150, 31);
            this.TXTBLastname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Firstname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lastname:";
            // 
            // BTNDeleteAccess
            // 
            this.BTNDeleteAccess.Location = new System.Drawing.Point(81, 552);
            this.BTNDeleteAccess.Name = "BTNDeleteAccess";
            this.BTNDeleteAccess.Size = new System.Drawing.Size(150, 34);
            this.BTNDeleteAccess.TabIndex = 9;
            this.BTNDeleteAccess.Text = "Delete a User";
            this.BTNDeleteAccess.UseVisualStyleBackColor = true;
            this.BTNDeleteAccess.Click += new System.EventHandler(this.BTNDeleteAccess_Click);
            // 
            // ListviewUser
            // 
            this.ListviewUser.HideSelection = false;
            this.ListviewUser.Location = new System.Drawing.Point(385, 39);
            this.ListviewUser.Name = "ListviewUser";
            this.ListviewUser.Size = new System.Drawing.Size(494, 276);
            this.ListviewUser.TabIndex = 10;
            this.ListviewUser.UseCompatibleStateImageBehavior = false;
            this.ListviewUser.View = System.Windows.Forms.View.Details;
            this.ListviewUser.SelectedIndexChanged += new System.EventHandler(this.ListviewUser_SelectedIndexChanged);
            // 
            // BTNUpdateAccess
            // 
            this.BTNUpdateAccess.Location = new System.Drawing.Point(81, 592);
            this.BTNUpdateAccess.Name = "BTNUpdateAccess";
            this.BTNUpdateAccess.Size = new System.Drawing.Size(150, 34);
            this.BTNUpdateAccess.TabIndex = 12;
            this.BTNUpdateAccess.Text = "Update a User";
            this.BTNUpdateAccess.UseVisualStyleBackColor = true;
            this.BTNUpdateAccess.Click += new System.EventHandler(this.BTNUpdateAccess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.Location = new System.Drawing.Point(81, 346);
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(150, 31);
            this.TXTBEmail.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_User);
            this.groupBox1.Controls.Add(this.RB_Admin);
            this.groupBox1.Location = new System.Drawing.Point(81, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 106);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User role:";
            // 
            // RB_User
            // 
            this.RB_User.AutoSize = true;
            this.RB_User.Location = new System.Drawing.Point(9, 66);
            this.RB_User.Name = "RB_User";
            this.RB_User.Size = new System.Drawing.Size(72, 29);
            this.RB_User.TabIndex = 1;
            this.RB_User.TabStop = true;
            this.RB_User.Text = "User";
            this.RB_User.UseVisualStyleBackColor = true;
            // 
            // RB_Admin
            // 
            this.RB_Admin.AutoSize = true;
            this.RB_Admin.Location = new System.Drawing.Point(9, 30);
            this.RB_Admin.Name = "RB_Admin";
            this.RB_Admin.Size = new System.Drawing.Size(90, 29);
            this.RB_Admin.TabIndex = 0;
            this.RB_Admin.TabStop = true;
            this.RB_Admin.Text = "Admin";
            this.RB_Admin.UseVisualStyleBackColor = true;
            // 
            // FormTapharo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXTBEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNUpdateAccess);
            this.Controls.Add(this.ListviewUser);
            this.Controls.Add(this.BTNDeleteAccess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBLastname);
            this.Controls.Add(this.TXTBFirstname);
            this.Controls.Add(this.TXTBPassword);
            this.Controls.Add(this.TXTBUsername);
            this.Controls.Add(this.BTNInsertUser);
            this.Name = "FormTapharo";
            this.Text = "FormTapharo";
            this.Load += new System.EventHandler(this.FormTapharo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNInsertUser;
        private System.Windows.Forms.TextBox TXTBUsername;
        private System.Windows.Forms.TextBox TXTBPassword;
        private System.Windows.Forms.TextBox TXTBFirstname;
        private System.Windows.Forms.TextBox TXTBLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNDeleteAccess;
        private System.Windows.Forms.ListView ListviewUser;
        private System.Windows.Forms.Button BTNUpdateAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTBEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_User;
        private System.Windows.Forms.RadioButton RB_Admin;
    }
}