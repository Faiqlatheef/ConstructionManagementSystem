namespace AyuboDriveFinal
{
    partial class mainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormAdmin));
            this.Xlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staffPaymentLabel = new System.Windows.Forms.Label();
            this.staffTypeLabel = new System.Windows.Forms.Label();
            this.staffsLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.staffLeaveLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.staffPaymentLabel);
            this.panel2.Controls.Add(this.staffTypeLabel);
            this.panel2.Controls.Add(this.staffsLabel);
            this.panel2.Controls.Add(this.projectLabel);
            this.panel2.Controls.Add(this.paymentLabel);
            this.panel2.Controls.Add(this.clientLabel);
            this.panel2.Controls.Add(this.staffLeaveLabel);
            this.panel2.Controls.Add(this.homeLabel);
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 692);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // staffPaymentLabel
            // 
            this.staffPaymentLabel.AutoSize = true;
            this.staffPaymentLabel.BackColor = System.Drawing.Color.White;
            this.staffPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffPaymentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffPaymentLabel.Location = new System.Drawing.Point(34, 252);
            this.staffPaymentLabel.Name = "staffPaymentLabel";
            this.staffPaymentLabel.Size = new System.Drawing.Size(148, 17);
            this.staffPaymentLabel.TabIndex = 3;
            this.staffPaymentLabel.Text = "> STAFF PAYMENT";
            this.staffPaymentLabel.Click += new System.EventHandler(this.staffPaymentLabel_Click);
            // 
            // staffTypeLabel
            // 
            this.staffTypeLabel.AutoSize = true;
            this.staffTypeLabel.BackColor = System.Drawing.Color.White;
            this.staffTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffTypeLabel.Location = new System.Drawing.Point(34, 184);
            this.staffTypeLabel.Name = "staffTypeLabel";
            this.staffTypeLabel.Size = new System.Drawing.Size(115, 17);
            this.staffTypeLabel.TabIndex = 4;
            this.staffTypeLabel.Text = "> STAFF TYPE";
            this.staffTypeLabel.Click += new System.EventHandler(this.staffTypeLabel_Click);
            // 
            // staffsLabel
            // 
            this.staffsLabel.AutoSize = true;
            this.staffsLabel.BackColor = System.Drawing.Color.White;
            this.staffsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffsLabel.Location = new System.Drawing.Point(34, 118);
            this.staffsLabel.Name = "staffsLabel";
            this.staffsLabel.Size = new System.Drawing.Size(80, 17);
            this.staffsLabel.TabIndex = 5;
            this.staffsLabel.Text = "> STAFFS";
            this.staffsLabel.Click += new System.EventHandler(this.staffsLabel_Click);
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.BackColor = System.Drawing.Color.White;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.projectLabel.Location = new System.Drawing.Point(35, 455);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(93, 17);
            this.projectLabel.TabIndex = 6;
            this.projectLabel.Text = "> PROJECT";
            this.projectLabel.Click += new System.EventHandler(this.projectLabel_Click);
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.BackColor = System.Drawing.Color.White;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paymentLabel.Location = new System.Drawing.Point(35, 519);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(95, 17);
            this.paymentLabel.TabIndex = 7;
            this.paymentLabel.Text = "> PAYMENT";
            this.paymentLabel.Click += new System.EventHandler(this.paymentLabel_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.White;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientLabel.Location = new System.Drawing.Point(34, 387);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(76, 17);
            this.clientLabel.TabIndex = 8;
            this.clientLabel.Text = "> CLIENT";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // staffLeaveLabel
            // 
            this.staffLeaveLabel.AutoSize = true;
            this.staffLeaveLabel.BackColor = System.Drawing.Color.White;
            this.staffLeaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLeaveLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffLeaveLabel.Location = new System.Drawing.Point(34, 323);
            this.staffLeaveLabel.Name = "staffLeaveLabel";
            this.staffLeaveLabel.Size = new System.Drawing.Size(124, 17);
            this.staffLeaveLabel.TabIndex = 9;
            this.staffLeaveLabel.Text = "> STAFF LEAVE";
            this.staffLeaveLabel.Click += new System.EventHandler(this.staffLeaveLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.White;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeLabel.Location = new System.Drawing.Point(34, 55);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(67, 17);
            this.homeLabel.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Construction Management System";
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label staffPaymentLabel;
        private System.Windows.Forms.Label staffTypeLabel;
        private System.Windows.Forms.Label staffsLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label staffLeaveLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label6;
    }
}