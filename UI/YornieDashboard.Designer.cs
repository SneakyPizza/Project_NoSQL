namespace UI
{
    partial class YornieDashboard
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
            this.lbl_openTickets = new System.Windows.Forms.Label();
            this.lbl_overTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_openTickets
            // 
            this.lbl_openTickets.AutoSize = true;
            this.lbl_openTickets.Location = new System.Drawing.Point(151, 146);
            this.lbl_openTickets.Name = "lbl_openTickets";
            this.lbl_openTickets.Size = new System.Drawing.Size(65, 15);
            this.lbl_openTickets.TabIndex = 0;
            this.lbl_openTickets.Text = "unresolved";
            // 
            // lbl_overTime
            // 
            this.lbl_overTime.AutoSize = true;
            this.lbl_overTime.Location = new System.Drawing.Point(466, 146);
            this.lbl_overTime.Name = "lbl_overTime";
            this.lbl_overTime.Size = new System.Drawing.Size(65, 15);
            this.lbl_overTime.TabIndex = 1;
            this.lbl_overTime.Text = "Over time: ";
            // 
            // YornieDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_overTime);
            this.Controls.Add(this.lbl_openTickets);
            this.Name = "YornieDashboard";
            this.Text = "YornieDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_openTickets;
        private System.Windows.Forms.Label lbl_overTime;
    }
}