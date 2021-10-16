
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            this.lbl_UserFullname = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_TicketHandeldBy = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_TicketoverviewNormalUser = new System.Windows.Forms.Panel();
            this.btn_CreateTicketNormalUser = new System.Windows.Forms.Button();
            this.lv_TicketOfNormalUser = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.IncidentType = new System.Windows.Forms.ColumnHeader();
            this.Priority = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.Completed = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richtb_TicketDescriptionMakeTicketNormalUser = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SubmitTicket = new System.Windows.Forms.Button();
            this.cb_TicketIncidentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TicketTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_TicketoverviewNormalUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_UserFullname
            // 
            this.lbl_UserFullname.AutoSize = true;
            this.lbl_UserFullname.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserFullname.Location = new System.Drawing.Point(93, 74);
            this.lbl_UserFullname.Name = "lbl_UserFullname";
            this.lbl_UserFullname.Size = new System.Drawing.Size(228, 38);
            this.lbl_UserFullname.TabIndex = 3;
            this.lbl_UserFullname.Text = "lbl_UserFullname";
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
            this.label7.Location = new System.Drawing.Point(93, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Incident Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(93, 216);
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
            this.cbo_ticketStatus.Location = new System.Drawing.Point(235, 217);
            this.cbo_ticketStatus.Name = "cbo_ticketStatus";
            this.cbo_ticketStatus.Size = new System.Drawing.Size(151, 28);
            this.cbo_ticketStatus.TabIndex = 15;
            // 
            // cbo_TicketIncidentType
            // 
            this.cbo_TicketIncidentType.FormattingEnabled = true;
            this.cbo_TicketIncidentType.Location = new System.Drawing.Point(235, 160);
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
            this.btn_UpdateTicket.Click += new System.EventHandler(this.btn_UpdateTicket_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(93, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Priority";
            // 
            // cbo_TIcketPriority
            // 
            this.cbo_TIcketPriority.FormattingEnabled = true;
            this.cbo_TIcketPriority.Location = new System.Drawing.Point(234, 262);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(93, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Handeld By:";
            // 
            // cbo_TicketHandeldBy
            // 
            this.cbo_TicketHandeldBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_TicketHandeldBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_TicketHandeldBy.FormattingEnabled = true;
            this.cbo_TicketHandeldBy.Location = new System.Drawing.Point(232, 313);
            this.cbo_TicketHandeldBy.Name = "cbo_TicketHandeldBy";
            this.cbo_TicketHandeldBy.Size = new System.Drawing.Size(151, 28);
            this.cbo_TicketHandeldBy.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_TicketoverviewNormalUser
            // 
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.panel1);
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.btn_CreateTicketNormalUser);
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.lv_TicketOfNormalUser);
            this.pnl_TicketoverviewNormalUser.Location = new System.Drawing.Point(12, 12);
            this.pnl_TicketoverviewNormalUser.Name = "pnl_TicketoverviewNormalUser";
            this.pnl_TicketoverviewNormalUser.Size = new System.Drawing.Size(1071, 531);
            this.pnl_TicketoverviewNormalUser.TabIndex = 24;
            // 
            // btn_CreateTicketNormalUser
            // 
            this.btn_CreateTicketNormalUser.Location = new System.Drawing.Point(84, 70);
            this.btn_CreateTicketNormalUser.Name = "btn_CreateTicketNormalUser";
            this.btn_CreateTicketNormalUser.Size = new System.Drawing.Size(225, 106);
            this.btn_CreateTicketNormalUser.TabIndex = 1;
            this.btn_CreateTicketNormalUser.Text = "Create Ticket";
            this.btn_CreateTicketNormalUser.UseVisualStyleBackColor = true;
            this.btn_CreateTicketNormalUser.Click += new System.EventHandler(this.btn_CreateTicketNormalUser_Click);
            // 
            // lv_TicketOfNormalUser
            // 
            this.lv_TicketOfNormalUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.IncidentType,
            this.Priority,
            this.Status,
            this.Completed});
            this.lv_TicketOfNormalUser.GridLines = true;
            this.lv_TicketOfNormalUser.HideSelection = false;
            this.lv_TicketOfNormalUser.Location = new System.Drawing.Point(457, 6);
            this.lv_TicketOfNormalUser.Name = "lv_TicketOfNormalUser";
            this.lv_TicketOfNormalUser.Size = new System.Drawing.Size(611, 525);
            this.lv_TicketOfNormalUser.TabIndex = 0;
            this.lv_TicketOfNormalUser.UseCompatibleStateImageBehavior = false;
            this.lv_TicketOfNormalUser.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // IncidentType
            // 
            this.IncidentType.Text = "IncidentType";
            this.IncidentType.Width = 120;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 90;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 90;
            // 
            // Completed
            // 
            this.Completed.Text = "Completed";
            this.Completed.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_TicketTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_TicketIncidentType);
            this.panel1.Controls.Add(this.btn_SubmitTicket);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richtb_TicketDescriptionMakeTicketNormalUser);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 522);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // richtb_TicketDescriptionMakeTicketNormalUser
            // 
            this.richtb_TicketDescriptionMakeTicketNormalUser.Location = new System.Drawing.Point(516, 117);
            this.richtb_TicketDescriptionMakeTicketNormalUser.Name = "richtb_TicketDescriptionMakeTicketNormalUser";
            this.richtb_TicketDescriptionMakeTicketNormalUser.Size = new System.Drawing.Size(482, 228);
            this.richtb_TicketDescriptionMakeTicketNormalUser.TabIndex = 0;
            this.richtb_TicketDescriptionMakeTicketNormalUser.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(516, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // btn_SubmitTicket
            // 
            this.btn_SubmitTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SubmitTicket.Location = new System.Drawing.Point(792, 371);
            this.btn_SubmitTicket.Name = "btn_SubmitTicket";
            this.btn_SubmitTicket.Size = new System.Drawing.Size(206, 85);
            this.btn_SubmitTicket.TabIndex = 2;
            this.btn_SubmitTicket.Text = "Submit";
            this.btn_SubmitTicket.UseVisualStyleBackColor = true;
            // 
            // cb_TicketIncidentType
            // 
            this.cb_TicketIncidentType.FormattingEnabled = true;
            this.cb_TicketIncidentType.Location = new System.Drawing.Point(182, 199);
            this.cb_TicketIncidentType.Name = "cb_TicketIncidentType";
            this.cb_TicketIncidentType.Size = new System.Drawing.Size(151, 28);
            this.cb_TicketIncidentType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "IncidentType";
            // 
            // tb_TicketTitle
            // 
            this.tb_TicketTitle.Location = new System.Drawing.Point(182, 154);
            this.tb_TicketTitle.Name = "tb_TicketTitle";
            this.tb_TicketTitle.Size = new System.Drawing.Size(151, 27);
            this.tb_TicketTitle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Deadline";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "7 Days";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1095, 555);
            this.Controls.Add(this.pnl_TicketoverviewNormalUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbo_TicketHandeldBy);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.lbl_UserFullname);
            this.Name = "FormTicket";
            this.Text = "FormTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_TicketoverviewNormalUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UserFullname;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_TicketHandeldBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_TicketoverviewNormalUser;
        private System.Windows.Forms.ListView lv_TicketOfNormalUser;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader IncidentType;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Completed;
        private System.Windows.Forms.Button btn_CreateTicketNormalUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_TicketIncidentType;
        private System.Windows.Forms.Button btn_SubmitTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtb_TicketDescriptionMakeTicketNormalUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TicketTitle;
        private System.Windows.Forms.Label label2;
    }
}