namespace AyuboDriveFinal
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.Xlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalOutcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.staffPaymentLabel = new System.Windows.Forms.Label();
            this.staffsLabel = new System.Windows.Forms.Label();
            this.staffLeaveLabel = new System.Windows.Forms.Label();
            this.staffAttendanceLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.leaveTypeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlabel.ForeColor = System.Drawing.Color.Red;
            this.Xlabel.Location = new System.Drawing.Point(1226, 9);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(27, 25);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "X";
            this.Xlabel.Click += new System.EventHandler(this.Xlabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Xlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 43);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Construction Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(199, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 692);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.searchLabel);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.projectsLabel);
            this.panel2.Controls.Add(this.clientLabel);
            this.panel2.Controls.Add(this.staffPaymentLabel);
            this.panel2.Controls.Add(this.staffsLabel);
            this.panel2.Controls.Add(this.staffLeaveLabel);
            this.panel2.Controls.Add(this.staffAttendanceLabel);
            this.panel2.Controls.Add(this.homeLabel);
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 692);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(12, 190);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(137, 17);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "> STAFF SEARCH";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leaveTypeLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.totalIncomeLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalOutcomeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reoprts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "> PAYMENTS FROM \r\n    PAYMENT TYPE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "> STAFF STATUS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.BackColor = System.Drawing.Color.White;
            this.totalIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalIncomeLabel.Location = new System.Drawing.Point(3, 31);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(123, 17);
            this.totalIncomeLabel.TabIndex = 13;
            this.totalIncomeLabel.Text = "> TOTAL INCOME";
            this.totalIncomeLabel.Click += new System.EventHandler(this.totalIncomeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "> PROJECTS TRACKING";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalOutcomeLabel
            // 
            this.totalOutcomeLabel.AutoSize = true;
            this.totalOutcomeLabel.BackColor = System.Drawing.Color.White;
            this.totalOutcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalOutcomeLabel.Location = new System.Drawing.Point(3, 63);
            this.totalOutcomeLabel.Name = "totalOutcomeLabel";
            this.totalOutcomeLabel.Size = new System.Drawing.Size(140, 17);
            this.totalOutcomeLabel.TabIndex = 9;
            this.totalOutcomeLabel.Text = "> TOTAL OUTCOME";
            this.totalOutcomeLabel.Click += new System.EventHandler(this.totalOutcomeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "> STAFF LEAVE BY DATE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "> STAFF ATTENDANCE \r\n    BY DATE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // projectsLabel
            // 
            this.projectsLabel.AutoSize = true;
            this.projectsLabel.BackColor = System.Drawing.Color.White;
            this.projectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.projectsLabel.Location = new System.Drawing.Point(12, 264);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(103, 17);
            this.projectsLabel.TabIndex = 13;
            this.projectsLabel.Text = "> PROJECTS";
            this.projectsLabel.Click += new System.EventHandler(this.projectsLabel_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.White;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientLabel.Location = new System.Drawing.Point(12, 225);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(76, 17);
            this.clientLabel.TabIndex = 12;
            this.clientLabel.Text = "> CLIENT";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // staffPaymentLabel
            // 
            this.staffPaymentLabel.AutoSize = true;
            this.staffPaymentLabel.BackColor = System.Drawing.Color.White;
            this.staffPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffPaymentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffPaymentLabel.Location = new System.Drawing.Point(12, 121);
            this.staffPaymentLabel.Name = "staffPaymentLabel";
            this.staffPaymentLabel.Size = new System.Drawing.Size(148, 17);
            this.staffPaymentLabel.TabIndex = 9;
            this.staffPaymentLabel.Text = "> STAFF PAYMENT";
            this.staffPaymentLabel.Click += new System.EventHandler(this.staffPaymentLabel_Click);
            // 
            // staffsLabel
            // 
            this.staffsLabel.AutoSize = true;
            this.staffsLabel.BackColor = System.Drawing.Color.White;
            this.staffsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffsLabel.Location = new System.Drawing.Point(12, 52);
            this.staffsLabel.Name = "staffsLabel";
            this.staffsLabel.Size = new System.Drawing.Size(80, 17);
            this.staffsLabel.TabIndex = 10;
            this.staffsLabel.Text = "> STAFFS";
            this.staffsLabel.Click += new System.EventHandler(this.staffsLabel_Click);
            // 
            // staffLeaveLabel
            // 
            this.staffLeaveLabel.AutoSize = true;
            this.staffLeaveLabel.BackColor = System.Drawing.Color.White;
            this.staffLeaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLeaveLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffLeaveLabel.Location = new System.Drawing.Point(12, 87);
            this.staffLeaveLabel.Name = "staffLeaveLabel";
            this.staffLeaveLabel.Size = new System.Drawing.Size(124, 17);
            this.staffLeaveLabel.TabIndex = 11;
            this.staffLeaveLabel.Text = "> STAFF LEAVE";
            this.staffLeaveLabel.Click += new System.EventHandler(this.staffLeaveLabel_Click);
            // 
            // staffAttendanceLabel
            // 
            this.staffAttendanceLabel.AutoSize = true;
            this.staffAttendanceLabel.BackColor = System.Drawing.Color.White;
            this.staffAttendanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffAttendanceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffAttendanceLabel.Location = new System.Drawing.Point(12, 156);
            this.staffAttendanceLabel.Name = "staffAttendanceLabel";
            this.staffAttendanceLabel.Size = new System.Drawing.Size(178, 17);
            this.staffAttendanceLabel.TabIndex = 7;
            this.staffAttendanceLabel.Text = "> STAFF ATTENDANCE";
            this.staffAttendanceLabel.Click += new System.EventHandler(this.staffAttendanceLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.White;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeLabel.Location = new System.Drawing.Point(12, 21);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(67, 17);
            this.homeLabel.TabIndex = 8;
            this.homeLabel.Text = "> HOME";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click_1);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.Red;
            this.logoutbtn.Location = new System.Drawing.Point(15, 615);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(169, 65);
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // leaveTypeLabel
            // 
            this.leaveTypeLabel.AutoSize = true;
            this.leaveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTypeLabel.Location = new System.Drawing.Point(7, 164);
            this.leaveTypeLabel.Name = "leaveTypeLabel";
            this.leaveTypeLabel.Size = new System.Drawing.Size(155, 34);
            this.leaveTypeLabel.TabIndex = 16;
            this.leaveTypeLabel.Text = "> STAFF LEAVE TYPE \r\n   BY DATE";
            this.leaveTypeLabel.Click += new System.EventHandler(this.leaveTypeLabel_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label staffPaymentLabel;
        private System.Windows.Forms.Label staffsLabel;
        private System.Windows.Forms.Label staffLeaveLabel;
        private System.Windows.Forms.Label staffAttendanceLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label totalOutcomeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label leaveTypeLabel;

    }
}