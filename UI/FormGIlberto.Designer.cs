
namespace UI
{
    partial class FormGIlberto
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
            this.comboBox_IncidentType = new System.Windows.Forms.ComboBox();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.comboBox_Priority = new System.Windows.Forms.ComboBox();
            this.comboBox_Deadline = new System.Windows.Forms.ComboBox();
            this.txt_SubjectIncident = new System.Windows.Forms.TextBox();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox_IncidentType
            // 
            this.comboBox_IncidentType.FormattingEnabled = true;
            this.comboBox_IncidentType.Location = new System.Drawing.Point(382, 130);
            this.comboBox_IncidentType.Name = "comboBox_IncidentType";
            this.comboBox_IncidentType.Size = new System.Drawing.Size(151, 28);
            this.comboBox_IncidentType.TabIndex = 1;
            // 
            // comboBox_User
            // 
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(382, 186);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(151, 28);
            this.comboBox_User.TabIndex = 2;
            // 
            // comboBox_Priority
            // 
            this.comboBox_Priority.FormattingEnabled = true;
            this.comboBox_Priority.Location = new System.Drawing.Point(382, 237);
            this.comboBox_Priority.Name = "comboBox_Priority";
            this.comboBox_Priority.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Priority.TabIndex = 3;
            // 
            // comboBox_Deadline
            // 
            this.comboBox_Deadline.FormattingEnabled = true;
            this.comboBox_Deadline.Items.AddRange(new object[] {
            "1 day",
            "2 days",
            "3 days",
            "4 days",
            "5 days",
            "6 days",
            "7 days"});
            this.comboBox_Deadline.Location = new System.Drawing.Point(382, 277);
            this.comboBox_Deadline.Name = "comboBox_Deadline";
            this.comboBox_Deadline.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Deadline.TabIndex = 4;
            // 
            // txt_SubjectIncident
            // 
            this.txt_SubjectIncident.Location = new System.Drawing.Point(382, 88);
            this.txt_SubjectIncident.Name = "txt_SubjectIncident";
            this.txt_SubjectIncident.Size = new System.Drawing.Size(151, 27);
            this.txt_SubjectIncident.TabIndex = 5;
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(382, 338);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(160, 135);
            this.richTextBox_Description.TabIndex = 6;
            this.richTextBox_Description.Text = "";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(503, 503);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(94, 29);
            this.Btn_Submit.TabIndex = 7;
            this.Btn_Submit.Text = "submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(382, 503);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date reported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "subject incident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "type incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "reported by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Deadline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Description";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(382, 45);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.DateTimePicker.TabIndex = 16;
            // 
            // FormGIlberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 575);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.txt_SubjectIncident);
            this.Controls.Add(this.comboBox_Deadline);
            this.Controls.Add(this.comboBox_Priority);
            this.Controls.Add(this.comboBox_User);
            this.Controls.Add(this.comboBox_IncidentType);
            this.Name = "FormGIlberto";
            this.Text = "FormGIlberto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_IncidentType;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.ComboBox comboBox_Priority;
        private System.Windows.Forms.ComboBox comboBox_Deadline;
        private System.Windows.Forms.TextBox txt_SubjectIncident;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}