namespace AyuboDriveFinal
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.payTime = new System.Windows.Forms.DateTimePicker();
            this.projectIDcomboBox = new System.Windows.Forms.ComboBox();
            this.clntcomboBox = new System.Windows.Forms.ComboBox();
            this.payTypecomboBox = new System.Windows.Forms.ComboBox();
            this.billDisplayBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadtable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prntbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.amountBox);
            this.groupBox1.Controls.Add(this.payTime);
            this.groupBox1.Controls.Add(this.projectIDcomboBox);
            this.groupBox1.Controls.Add(this.clntcomboBox);
            this.groupBox1.Controls.Add(this.payTypecomboBox);
            this.groupBox1.Controls.Add(this.billDisplayBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.loadtable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 587);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(176, 225);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(247, 22);
            this.amountBox.TabIndex = 52;
            // 
            // payTime
            // 
            this.payTime.Enabled = false;
            this.payTime.Location = new System.Drawing.Point(176, 183);
            this.payTime.Name = "payTime";
            this.payTime.Size = new System.Drawing.Size(247, 22);
            this.payTime.TabIndex = 51;
            // 
            // projectIDcomboBox
            // 
            this.projectIDcomboBox.FormattingEnabled = true;
            this.projectIDcomboBox.Location = new System.Drawing.Point(176, 110);
            this.projectIDcomboBox.Name = "projectIDcomboBox";
            this.projectIDcomboBox.Size = new System.Drawing.Size(247, 24);
            this.projectIDcomboBox.TabIndex = 50;
            // 
            // clntcomboBox
            // 
            this.clntcomboBox.FormattingEnabled = true;
            this.clntcomboBox.Location = new System.Drawing.Point(176, 78);
            this.clntcomboBox.Name = "clntcomboBox";
            this.clntcomboBox.Size = new System.Drawing.Size(247, 24);
            this.clntcomboBox.TabIndex = 50;
            // 
            // payTypecomboBox
            // 
            this.payTypecomboBox.FormattingEnabled = true;
            this.payTypecomboBox.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Card"});
            this.payTypecomboBox.Location = new System.Drawing.Point(176, 149);
            this.payTypecomboBox.Name = "payTypecomboBox";
            this.payTypecomboBox.Size = new System.Drawing.Size(247, 24);
            this.payTypecomboBox.TabIndex = 49;
            // 
            // billDisplayBox
            // 
            this.billDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDisplayBox.Location = new System.Drawing.Point(6, 271);
            this.billDisplayBox.Multiline = true;
            this.billDisplayBox.Name = "billDisplayBox";
            this.billDisplayBox.Size = new System.Drawing.Size(432, 310);
            this.billDisplayBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Payment Date :";
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
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Payment ID :";
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
            this.loadtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadtable_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Payment Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Project ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Client ID :";
            // 
            // prntbtn
            // 
            this.prntbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.prntbtn.Location = new System.Drawing.Point(423, 643);
            this.prntbtn.Name = "prntbtn";
            this.prntbtn.Size = new System.Drawing.Size(86, 37);
            this.prntbtn.TabIndex = 49;
            this.prntbtn.Text = "Print";
            this.prntbtn.UseVisualStyleBackColor = false;
            this.prntbtn.Click += new System.EventHandler(this.prntbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.prntbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.Savebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Payment_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.DateTimePicker startdateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox clientcomboBox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView loadtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox payTypecomboBox;
        private System.Windows.Forms.TextBox billDisplayBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prntbtn;
        private System.Windows.Forms.ComboBox projectIDcomboBox;
        private System.Windows.Forms.ComboBox clntcomboBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.DateTimePicker payTime;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}