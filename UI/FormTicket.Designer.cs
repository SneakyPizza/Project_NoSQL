
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
            this.pnl_CreateTicketNormalUser = new System.Windows.Forms.Panel();
            this.pnl_SeeTicket = new System.Windows.Forms.Panel();
            this.lbl_handeldBy = new System.Windows.Forms.Label();
            this.lbl_TicketPriority = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.richtb_TicketDescriptionNormalUser = new System.Windows.Forms.RichTextBox();
            this.richtb_TicketSolutionNormalUser = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_TicketDeadline = new System.Windows.Forms.Label();
            this.lbl_TicketCreationTime = new System.Windows.Forms.Label();
            this.lbl_TicketStatus = new System.Windows.Forms.Label();
            this.lbl_TicketTitle = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TicketTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TicketIncidentType = new System.Windows.Forms.ComboBox();
            this.btn_SubmitTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richtb_TicketDescriptionMakeTicketNormalUser = new System.Windows.Forms.RichTextBox();
            this.btn_CreateTicketNormalUser = new System.Windows.Forms.Button();
            this.lv_TicketOfNormalUser = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.IncidentType = new System.Windows.Forms.ColumnHeader();
            this.Priority = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.Completed = new System.Windows.Forms.ColumnHeader();
            this.pic_backToUserTicketList = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_TicketoverviewNormalUser.SuspendLayout();
            this.pnl_CreateTicketNormalUser.SuspendLayout();
            this.pnl_SeeTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_backToUserTicketList)).BeginInit();
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
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.pnl_CreateTicketNormalUser);
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.btn_CreateTicketNormalUser);
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.lv_TicketOfNormalUser);
            this.pnl_TicketoverviewNormalUser.Controls.Add(this.pic_backToUserTicketList);
            this.pnl_TicketoverviewNormalUser.Location = new System.Drawing.Point(12, 12);
            this.pnl_TicketoverviewNormalUser.Name = "pnl_TicketoverviewNormalUser";
            this.pnl_TicketoverviewNormalUser.Size = new System.Drawing.Size(1071, 531);
            this.pnl_TicketoverviewNormalUser.TabIndex = 24;
            // 
            // pnl_CreateTicketNormalUser
            // 
            this.pnl_CreateTicketNormalUser.Controls.Add(this.pnl_SeeTicket);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.pictureBox2);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.label13);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.label5);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.label4);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.tb_TicketTitle);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.label2);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.cb_TicketIncidentType);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.btn_SubmitTicket);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.label1);
            this.pnl_CreateTicketNormalUser.Controls.Add(this.richtb_TicketDescriptionMakeTicketNormalUser);
            this.pnl_CreateTicketNormalUser.Location = new System.Drawing.Point(7, 9);
            this.pnl_CreateTicketNormalUser.Name = "pnl_CreateTicketNormalUser";
            this.pnl_CreateTicketNormalUser.Size = new System.Drawing.Size(1064, 522);
            this.pnl_CreateTicketNormalUser.TabIndex = 2;
            this.pnl_CreateTicketNormalUser.Visible = false;
            // 
            // pnl_SeeTicket
            // 
            this.pnl_SeeTicket.Controls.Add(this.lbl_handeldBy);
            this.pnl_SeeTicket.Controls.Add(this.lbl_TicketPriority);
            this.pnl_SeeTicket.Controls.Add(this.label25);
            this.pnl_SeeTicket.Controls.Add(this.label24);
            this.pnl_SeeTicket.Controls.Add(this.label23);
            this.pnl_SeeTicket.Controls.Add(this.richtb_TicketDescriptionNormalUser);
            this.pnl_SeeTicket.Controls.Add(this.richtb_TicketSolutionNormalUser);
            this.pnl_SeeTicket.Controls.Add(this.label22);
            this.pnl_SeeTicket.Controls.Add(this.lbl_TicketDeadline);
            this.pnl_SeeTicket.Controls.Add(this.lbl_TicketCreationTime);
            this.pnl_SeeTicket.Controls.Add(this.lbl_TicketStatus);
            this.pnl_SeeTicket.Controls.Add(this.lbl_TicketTitle);
            this.pnl_SeeTicket.Controls.Add(this.label17);
            this.pnl_SeeTicket.Controls.Add(this.label16);
            this.pnl_SeeTicket.Controls.Add(this.label15);
            this.pnl_SeeTicket.Controls.Add(this.label14);
            this.pnl_SeeTicket.Controls.Add(this.pictureBox3);
            this.pnl_SeeTicket.Location = new System.Drawing.Point(3, 3);
            this.pnl_SeeTicket.Name = "pnl_SeeTicket";
            this.pnl_SeeTicket.Size = new System.Drawing.Size(1044, 506);
            this.pnl_SeeTicket.TabIndex = 10;
            // 
            // lbl_handeldBy
            // 
            this.lbl_handeldBy.AutoSize = true;
            this.lbl_handeldBy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_handeldBy.Location = new System.Drawing.Point(272, 221);
            this.lbl_handeldBy.Name = "lbl_handeldBy";
            this.lbl_handeldBy.Size = new System.Drawing.Size(69, 25);
            this.lbl_handeldBy.TabIndex = 20;
            this.lbl_handeldBy.Text = "label18";
            // 
            // lbl_TicketPriority
            // 
            this.lbl_TicketPriority.AutoSize = true;
            this.lbl_TicketPriority.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TicketPriority.Location = new System.Drawing.Point(271, 183);
            this.lbl_TicketPriority.Name = "lbl_TicketPriority";
            this.lbl_TicketPriority.Size = new System.Drawing.Size(139, 25);
            this.lbl_TicketPriority.TabIndex = 19;
            this.lbl_TicketPriority.Text = "lbl_TicketPriority";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(138, 183);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 25);
            this.label25.TabIndex = 18;
            this.label25.Text = "Priority";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(636, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 25);
            this.label24.TabIndex = 17;
            this.label24.Text = "Description";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(635, 244);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 25);
            this.label23.TabIndex = 16;
            this.label23.Text = "Solution";
            // 
            // richtb_TicketDescriptionNormalUser
            // 
            this.richtb_TicketDescriptionNormalUser.Location = new System.Drawing.Point(636, 54);
            this.richtb_TicketDescriptionNormalUser.Name = "richtb_TicketDescriptionNormalUser";
            this.richtb_TicketDescriptionNormalUser.Size = new System.Drawing.Size(351, 173);
            this.richtb_TicketDescriptionNormalUser.TabIndex = 15;
            this.richtb_TicketDescriptionNormalUser.Text = "";
            // 
            // richtb_TicketSolutionNormalUser
            // 
            this.richtb_TicketSolutionNormalUser.Location = new System.Drawing.Point(635, 282);
            this.richtb_TicketSolutionNormalUser.Name = "richtb_TicketSolutionNormalUser";
            this.richtb_TicketSolutionNormalUser.Size = new System.Drawing.Size(351, 171);
            this.richtb_TicketSolutionNormalUser.TabIndex = 14;
            this.richtb_TicketSolutionNormalUser.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(138, 301);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 25);
            this.label22.TabIndex = 12;
            this.label22.Text = "Deadline";
            // 
            // lbl_TicketDeadline
            // 
            this.lbl_TicketDeadline.AutoSize = true;
            this.lbl_TicketDeadline.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TicketDeadline.Location = new System.Drawing.Point(272, 301);
            this.lbl_TicketDeadline.Name = "lbl_TicketDeadline";
            this.lbl_TicketDeadline.Size = new System.Drawing.Size(69, 25);
            this.lbl_TicketDeadline.TabIndex = 11;
            this.lbl_TicketDeadline.Text = "label21";
            // 
            // lbl_TicketCreationTime
            // 
            this.lbl_TicketCreationTime.AutoSize = true;
            this.lbl_TicketCreationTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TicketCreationTime.Location = new System.Drawing.Point(271, 262);
            this.lbl_TicketCreationTime.Name = "lbl_TicketCreationTime";
            this.lbl_TicketCreationTime.Size = new System.Drawing.Size(69, 25);
            this.lbl_TicketCreationTime.TabIndex = 10;
            this.lbl_TicketCreationTime.Text = "label20";
            // 
            // lbl_TicketStatus
            // 
            this.lbl_TicketStatus.AutoSize = true;
            this.lbl_TicketStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TicketStatus.Location = new System.Drawing.Point(271, 139);
            this.lbl_TicketStatus.Name = "lbl_TicketStatus";
            this.lbl_TicketStatus.Size = new System.Drawing.Size(69, 25);
            this.lbl_TicketStatus.TabIndex = 9;
            this.lbl_TicketStatus.Text = "label19";
            // 
            // lbl_TicketTitle
            // 
            this.lbl_TicketTitle.AutoSize = true;
            this.lbl_TicketTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TicketTitle.Location = new System.Drawing.Point(271, 89);
            this.lbl_TicketTitle.Name = "lbl_TicketTitle";
            this.lbl_TicketTitle.Size = new System.Drawing.Size(69, 25);
            this.lbl_TicketTitle.TabIndex = 8;
            this.lbl_TicketTitle.Text = "label18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(135, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "CreationTime";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(135, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 6;
            this.label16.Text = "Handeld By";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(138, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(135, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Title";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 52);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Deadline";
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
            // tb_TicketTitle
            // 
            this.tb_TicketTitle.Location = new System.Drawing.Point(182, 154);
            this.tb_TicketTitle.Name = "tb_TicketTitle";
            this.tb_TicketTitle.Size = new System.Drawing.Size(151, 27);
            this.tb_TicketTitle.TabIndex = 5;
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
            // cb_TicketIncidentType
            // 
            this.cb_TicketIncidentType.FormattingEnabled = true;
            this.cb_TicketIncidentType.Location = new System.Drawing.Point(182, 199);
            this.cb_TicketIncidentType.Name = "cb_TicketIncidentType";
            this.cb_TicketIncidentType.Size = new System.Drawing.Size(151, 28);
            this.cb_TicketIncidentType.TabIndex = 3;
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
            this.btn_SubmitTicket.Click += new System.EventHandler(this.btn_SubmitTicket_Click);
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
            // richtb_TicketDescriptionMakeTicketNormalUser
            // 
            this.richtb_TicketDescriptionMakeTicketNormalUser.Location = new System.Drawing.Point(516, 117);
            this.richtb_TicketDescriptionMakeTicketNormalUser.Name = "richtb_TicketDescriptionMakeTicketNormalUser";
            this.richtb_TicketDescriptionMakeTicketNormalUser.Size = new System.Drawing.Size(482, 228);
            this.richtb_TicketDescriptionMakeTicketNormalUser.TabIndex = 0;
            this.richtb_TicketDescriptionMakeTicketNormalUser.Text = "";
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
            this.lv_TicketOfNormalUser.FullRowSelect = true;
            this.lv_TicketOfNormalUser.GridLines = true;
            this.lv_TicketOfNormalUser.HideSelection = false;
            this.lv_TicketOfNormalUser.Location = new System.Drawing.Point(457, 6);
            this.lv_TicketOfNormalUser.Name = "lv_TicketOfNormalUser";
            this.lv_TicketOfNormalUser.Size = new System.Drawing.Size(611, 525);
            this.lv_TicketOfNormalUser.TabIndex = 0;
            this.lv_TicketOfNormalUser.UseCompatibleStateImageBehavior = false;
            this.lv_TicketOfNormalUser.View = System.Windows.Forms.View.Details;
            this.lv_TicketOfNormalUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_TicketOfNormalUser_MouseClick);
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
            // pic_backToUserTicketList
            // 
            this.pic_backToUserTicketList.Image = ((System.Drawing.Image)(resources.GetObject("pic_backToUserTicketList.Image")));
            this.pic_backToUserTicketList.Location = new System.Drawing.Point(3, 19);
            this.pic_backToUserTicketList.Name = "pic_backToUserTicketList";
            this.pic_backToUserTicketList.Size = new System.Drawing.Size(75, 56);
            this.pic_backToUserTicketList.TabIndex = 13;
            this.pic_backToUserTicketList.TabStop = false;
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
            this.pnl_CreateTicketNormalUser.ResumeLayout(false);
            this.pnl_CreateTicketNormalUser.PerformLayout();
            this.pnl_SeeTicket.ResumeLayout(false);
            this.pnl_SeeTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_backToUserTicketList)).EndInit();
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
        private System.Windows.Forms.Panel pnl_CreateTicketNormalUser;
        private System.Windows.Forms.ComboBox cb_TicketIncidentType;
        private System.Windows.Forms.Button btn_SubmitTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtb_TicketDescriptionMakeTicketNormalUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TicketTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnl_SeeTicket;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_TicketDeadline;
        private System.Windows.Forms.Label lbl_TicketCreationTime;
        private System.Windows.Forms.Label lbl_TicketStatus;
        private System.Windows.Forms.Label lbl_TicketTitle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox richtb_TicketDescriptionNormalUser;
        private System.Windows.Forms.RichTextBox richtb_TicketSolutionNormalUser;
        private System.Windows.Forms.PictureBox pic_backToUserTicketList;
        private System.Windows.Forms.Label lbl_TicketPriority;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_handeldBy;
    }
}