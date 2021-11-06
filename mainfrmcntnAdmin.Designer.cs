namespace AyuboDriveFinal
{
    partial class mainfrmcntnAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrmcntnAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Employeeslabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelabel = new System.Windows.Forms.Label();
            this.ProjectsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Employees :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Projects :";
            // 
            // Employeeslabel
            // 
            this.Employeeslabel.AutoSize = true;
            this.Employeeslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeeslabel.Location = new System.Drawing.Point(623, 136);
            this.Employeeslabel.Name = "Employeeslabel";
            this.Employeeslabel.Size = new System.Drawing.Size(52, 55);
            this.Employeeslabel.TabIndex = 1;
            this.Employeeslabel.Text = "0";
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
            // ProjectsLabel
            // 
            this.ProjectsLabel.AutoSize = true;
            this.ProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsLabel.Location = new System.Drawing.Point(623, 229);
            this.ProjectsLabel.Name = "ProjectsLabel";
            this.ProjectsLabel.Size = new System.Drawing.Size(52, 55);
            this.ProjectsLabel.TabIndex = 1;
            this.ProjectsLabel.Text = "0";
            // 
            // mainfrmcntnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.ProjectsLabel);
            this.Controls.Add(this.Employeeslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainfrmcntnAdmin";
            this.Text = "mainfrmcntn";
            this.Load += new System.EventHandler(this.mainfrmcntn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Employeeslabel;
        private System.Windows.Forms.Label trlabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label ProjectsLabel;
    }
}