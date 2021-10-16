
namespace UI
{
    partial class FormTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richtb_TicketDescription = new System.Windows.Forms.RichTextBox();
            this.richtb_TicketSolution = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_TicketDeadline = new System.Windows.Forms.DateTimePicker();
            this.dtp_TicketCreationTime = new System.Windows.Forms.DateTimePicker();
            this.cbo_ticketStatus = new System.Windows.Forms.ComboBox();
            this.cbo_TicketIncidentType = new System.Windows.Forms.ComboBox();
            this.btn_UpdateTicket = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_TIcketPriority = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(232, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "lbl_UserFirstname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(235, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "lbl_UserLastname";
            // 
            // richtb_TicketDescription
            // 
            this.richtb_TicketDescription.Location = new System.Drawing.Point(549, 74);
            this.richtb_TicketDescription.Name = "richtb_TicketDescription";
            this.richtb_TicketDescription.Size = new System.Drawing.Size(415, 137);
            this.richtb_TicketDescription.TabIndex = 5;
            this.richtb_TicketDescription.Text = "";
            // 
            // richtb_TicketSolution
            // 
            this.richtb_TicketSolution.Location = new System.Drawing.Point(549, 272);
            this.richtb_TicketSolution.Name = "richtb_TicketSolution";
            this.richtb_TicketSolution.Size = new System.Drawing.Size(415, 139);
            this.richtb_TicketSolution.TabIndex = 6;
            this.richtb_TicketSolution.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(549, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(549, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Solution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(93, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Incident Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(93, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(85, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Creation Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(85, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Deadline:";
            // 
            // dtp_TicketDeadline
            // 
            this.dtp_TicketDeadline.Location = new System.Drawing.Point(232, 416);
            this.dtp_TicketDeadline.Name = "dtp_TicketDeadline";
            this.dtp_TicketDeadline.Size = new System.Drawing.Size(250, 27);
            this.dtp_TicketDeadline.TabIndex = 13;
            // 
            // dtp_TicketCreationTime
            // 
            this.dtp_TicketCreationTime.Location = new System.Drawing.Point(232, 360);
            this.dtp_TicketCreationTime.Name = "dtp_TicketCreationTime";
            this.dtp_TicketCreationTime.Size = new System.Drawing.Size(250, 27);
            this.dtp_TicketCreationTime.TabIndex = 14;
            // 
            // cbo_ticketStatus
            // 
            this.cbo_ticketStatus.FormattingEnabled = true;
            this.cbo_ticketStatus.Location = new System.Drawing.Point(235, 240);
            this.cbo_ticketStatus.Name = "cbo_ticketStatus";
            this.cbo_ticketStatus.Size = new System.Drawing.Size(151, 28);
            this.cbo_ticketStatus.TabIndex = 15;
            // 
            // cbo_TicketIncidentType
            // 
            this.cbo_TicketIncidentType.FormattingEnabled = true;
            this.cbo_TicketIncidentType.Location = new System.Drawing.Point(235, 183);
            this.cbo_TicketIncidentType.Name = "cbo_TicketIncidentType";
            this.cbo_TicketIncidentType.Size = new System.Drawing.Size(151, 28);
            this.cbo_TicketIncidentType.TabIndex = 16;
            // 
            // btn_UpdateTicket
            // 
            this.btn_UpdateTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_UpdateTicket.Location = new System.Drawing.Point(769, 454);
            this.btn_UpdateTicket.Name = "btn_UpdateTicket";
            this.btn_UpdateTicket.Size = new System.Drawing.Size(195, 64);
            this.btn_UpdateTicket.TabIndex = 17;
            this.btn_UpdateTicket.Text = "Update";
            this.btn_UpdateTicket.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(93, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Priority";
            // 
            // cbo_TIcketPriority
            // 
            this.cbo_TIcketPriority.FormattingEnabled = true;
            this.cbo_TIcketPriority.Location = new System.Drawing.Point(234, 285);
            this.cbo_TIcketPriority.Name = "cbo_TIcketPriority";
            this.cbo_TIcketPriority.Size = new System.Drawing.Size(151, 28);
            this.cbo_TIcketPriority.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(549, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1095, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_TIcketPriority);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_UpdateTicket);
            this.Controls.Add(this.cbo_TicketIncidentType);
            this.Controls.Add(this.cbo_ticketStatus);
            this.Controls.Add(this.dtp_TicketCreationTime);
            this.Controls.Add(this.dtp_TicketDeadline);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richtb_TicketSolution);
            this.Controls.Add(this.richtb_TicketDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTicket";
            this.Text = "FormTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtb_TicketDescription;
        private System.Windows.Forms.RichTextBox richtb_TicketSolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_TicketDeadline;
        private System.Windows.Forms.DateTimePicker dtp_TicketCreationTime;
        private System.Windows.Forms.ComboBox cbo_ticketStatus;
        private System.Windows.Forms.ComboBox cbo_TicketIncidentType;
        private System.Windows.Forms.Button btn_UpdateTicket;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_TIcketPriority;
        private System.Windows.Forms.Button button1;
    }
}