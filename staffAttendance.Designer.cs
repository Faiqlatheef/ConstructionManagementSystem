namespace AyuboDriveFinal
{
    partial class staffAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffAttendance));
            this.clsbtn = new System.Windows.Forms.Button();
            this.groupBoxStaffAttendance = new System.Windows.Forms.GroupBox();
            this.buttonStaffSubmit = new System.Windows.Forms.Button();
            this.staffIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBoxStaffAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // clsbtn
            // 
            this.clsbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsbtn.ForeColor = System.Drawing.Color.Red;
            this.clsbtn.Location = new System.Drawing.Point(909, 623);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(145, 57);
            this.clsbtn.TabIndex = 8;
            this.clsbtn.Text = "CLOSE";
            this.clsbtn.UseVisualStyleBackColor = false;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // groupBoxStaffAttendance
            // 
            this.groupBoxStaffAttendance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxStaffAttendance.Controls.Add(this.buttonStaffSubmit);
            this.groupBoxStaffAttendance.Controls.Add(this.staffIDBox);
            this.groupBoxStaffAttendance.Controls.Add(this.label3);
            this.groupBoxStaffAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStaffAttendance.Location = new System.Drawing.Point(160, 255);
            this.groupBoxStaffAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStaffAttendance.Name = "groupBoxStaffAttendance";
            this.groupBoxStaffAttendance.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStaffAttendance.Size = new System.Drawing.Size(699, 158);
            this.groupBoxStaffAttendance.TabIndex = 9;
            this.groupBoxStaffAttendance.TabStop = false;
            this.groupBoxStaffAttendance.Text = "Staff Attendance";
            // 
            // buttonStaffSubmit
            // 
            this.buttonStaffSubmit.Location = new System.Drawing.Point(458, 63);
            this.buttonStaffSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStaffSubmit.Name = "buttonStaffSubmit";
            this.buttonStaffSubmit.Size = new System.Drawing.Size(143, 44);
            this.buttonStaffSubmit.TabIndex = 2;
            this.buttonStaffSubmit.Text = "Submit";
            this.buttonStaffSubmit.UseVisualStyleBackColor = true;
            this.buttonStaffSubmit.Click += new System.EventHandler(this.buttonStaffSubmit_Click);
            // 
            // staffIDBox
            // 
            this.staffIDBox.Location = new System.Drawing.Point(264, 71);
            this.staffIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.staffIDBox.Multiline = true;
            this.staffIDBox.Name = "staffIDBox";
            this.staffIDBox.Size = new System.Drawing.Size(165, 31);
            this.staffIDBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter ID   :";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SandyBrown;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Green;
            this.loginButton.Location = new System.Drawing.Point(12, 623);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(145, 57);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // staffAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.groupBoxStaffAttendance);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.clsbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBoxStaffAttendance.ResumeLayout(false);
            this.groupBoxStaffAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.GroupBox groupBoxStaffAttendance;
        private System.Windows.Forms.Button buttonStaffSubmit;
        private System.Windows.Forms.TextBox staffIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
    }
}