namespace AyuboDriveFinal
{
    partial class staffLeave
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staffaLeavedateTime = new System.Windows.Forms.DateTimePicker();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.staffcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadtable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaveTypecomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.LeaveTypecomboBox);
            this.groupBox1.Controls.Add(this.staffaLeavedateTime);
            this.groupBox1.Controls.Add(this.reasonBox);
            this.groupBox1.Controls.Add(this.staffcomboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.loadtable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 587);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Leave";
            // 
            // staffaLeavedateTime
            // 
            this.staffaLeavedateTime.Enabled = false;
            this.staffaLeavedateTime.Location = new System.Drawing.Point(176, 93);
            this.staffaLeavedateTime.Name = "staffaLeavedateTime";
            this.staffaLeavedateTime.Size = new System.Drawing.Size(247, 22);
            this.staffaLeavedateTime.TabIndex = 38;
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(176, 257);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(247, 22);
            this.reasonBox.TabIndex = 37;
            // 
            // staffcomboBox
            // 
            this.staffcomboBox.FormattingEnabled = true;
            this.staffcomboBox.Location = new System.Drawing.Point(176, 143);
            this.staffcomboBox.Name = "staffcomboBox";
            this.staffcomboBox.Size = new System.Drawing.Size(247, 24);
            this.staffcomboBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Staff Leave Date :";
            // 
            // idbox
            // 
            this.idbox.Enabled = false;
            this.idbox.Location = new System.Drawing.Point(176, 43);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(247, 22);
            this.idbox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Staff Leave ID :";
            // 
            // loadtable
            // 
            this.loadtable.AllowUserToAddRows = false;
            this.loadtable.AllowUserToDeleteRows = false;
            this.loadtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadtable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadtable.Location = new System.Drawing.Point(444, 21);
            this.loadtable.Name = "loadtable";
            this.loadtable.ReadOnly = true;
            this.loadtable.RowTemplate.Height = 24;
            this.loadtable.Size = new System.Drawing.Size(592, 560);
            this.loadtable.TabIndex = 25;
            this.loadtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadtable_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Leave Reason :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Staff ID :";
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.dltbtn.Location = new System.Drawing.Point(225, 642);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(101, 38);
            this.dltbtn.TabIndex = 47;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.updbtn.Location = new System.Drawing.Point(118, 642);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(101, 38);
            this.updbtn.TabIndex = 48;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Savebtn.Location = new System.Drawing.Point(12, 642);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(101, 38);
            this.Savebtn.TabIndex = 49;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clrbtn.Location = new System.Drawing.Point(332, 642);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(85, 37);
            this.clrbtn.TabIndex = 51;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Leave Type :";
            // 
            // LeaveTypecomboBox
            // 
            this.LeaveTypecomboBox.FormattingEnabled = true;
            this.LeaveTypecomboBox.Items.AddRange(new object[] {
            "Family and Medical Leave",
            "Casual Leave",
            "Sick Leave",
            "Maternity Leave",
            "Paternity Leave",
            "Compensatory Leave (Half Day)",
            "Unpaid Leave"});
            this.LeaveTypecomboBox.Location = new System.Drawing.Point(176, 200);
            this.LeaveTypecomboBox.Name = "LeaveTypecomboBox";
            this.LeaveTypecomboBox.Size = new System.Drawing.Size(247, 24);
            this.LeaveTypecomboBox.TabIndex = 39;
            // 
            // staffLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.Savebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffLeave";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Cash_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView loadtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.DateTimePicker startdateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.ComboBox clientcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.ComboBox staffcomboBox;
        private System.Windows.Forms.DateTimePicker leaveTime;
        private System.Windows.Forms.DateTimePicker staffaLeavedateTime;
        private System.Windows.Forms.ComboBox LeaveTypecomboBox;
        private System.Windows.Forms.Label label2;
    }
}