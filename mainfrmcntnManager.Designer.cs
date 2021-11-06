namespace AyuboDriveFinal
{
    partial class mainfrmcntnManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrmcntnManager));
            this.label3 = new System.Windows.Forms.Label();
            this.Profitlabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelabel = new System.Windows.Forms.Label();
            this.Projectslabel = new System.Windows.Forms.Label();
            this.Employeeslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(597, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Profit In This Month:";
            // 
            // Profitlabel
            // 
            this.Profitlabel.AutoSize = true;
            this.Profitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profitlabel.Location = new System.Drawing.Point(635, 415);
            this.Profitlabel.Name = "Profitlabel";
            this.Profitlabel.Size = new System.Drawing.Size(52, 55);
            this.Profitlabel.TabIndex = 1;
            this.Profitlabel.Text = "0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(919, 632);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(135, 32);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(13, 632);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(183, 32);
            this.datelabel.TabIndex = 3;
            this.datelabel.Text = "DD:MM:YYY";
            // 
            // Projectslabel
            // 
            this.Projectslabel.AutoSize = true;
            this.Projectslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projectslabel.Location = new System.Drawing.Point(635, 219);
            this.Projectslabel.Name = "Projectslabel";
            this.Projectslabel.Size = new System.Drawing.Size(52, 55);
            this.Projectslabel.TabIndex = 6;
            this.Projectslabel.Text = "0";
            // 
            // Employeeslabel
            // 
            this.Employeeslabel.AutoSize = true;
            this.Employeeslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeeslabel.Location = new System.Drawing.Point(635, 126);
            this.Employeeslabel.Name = "Employeeslabel";
            this.Employeeslabel.Size = new System.Drawing.Size(52, 55);
            this.Employeeslabel.TabIndex = 7;
            this.Employeeslabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Projects :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Employees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Profit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mainfrmcntnManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.Projectslabel);
            this.Controls.Add(this.Employeeslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Profitlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainfrmcntnManager";
            this.Text = "mainfrmcntn";
            this.Load += new System.EventHandler(this.mainfrmcntn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label thlabel;
        private System.Windows.Forms.Label Profitlabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label Projectslabel;
        private System.Windows.Forms.Label Employeeslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}