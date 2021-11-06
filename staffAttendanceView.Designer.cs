namespace AyuboDriveFinal
{
    partial class staffAttendanceView
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
            this.loadtable = new System.Windows.Forms.DataGridView();
            this.srchbtn = new System.Windows.Forms.Button();
            this.srchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).BeginInit();
            this.SuspendLayout();
            // 
            // loadtable
            // 
            this.loadtable.AllowUserToAddRows = false;
            this.loadtable.AllowUserToDeleteRows = false;
            this.loadtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadtable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadtable.Location = new System.Drawing.Point(35, 66);
            this.loadtable.Name = "loadtable";
            this.loadtable.ReadOnly = true;
            this.loadtable.RowTemplate.Height = 24;
            this.loadtable.Size = new System.Drawing.Size(996, 578);
            this.loadtable.TabIndex = 26;
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.srchbtn.Location = new System.Drawing.Point(946, 30);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(80, 32);
            this.srchbtn.TabIndex = 32;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // srchBox
            // 
            this.srchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchBox.Location = new System.Drawing.Point(734, 33);
            this.srchBox.Name = "srchBox";
            this.srchBox.Size = new System.Drawing.Size(206, 27);
            this.srchBox.TabIndex = 31;
            // 
            // staffAttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.srchBox);
            this.Controls.Add(this.loadtable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffAttendanceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadtable;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox srchBox;

    }
}