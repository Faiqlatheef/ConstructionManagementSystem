using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDriveFinal
{
    public partial class mainfrmcntnManager : Form
    {
        public mainfrmcntnManager()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void mainfrmcntn_Load(object sender, EventArgs e)
        {
            // assign to label
            DataTable hdt = A.getData("select count (*) from staffs");
            Employeeslabel.Text = hdt.Rows[0][0].ToString();

            DataTable rdt = A.getData("select count (*) from Project");
            Projectslabel.Text = rdt.Rows[0][0].ToString();

            //calculate total income by current month 
            DataTable ddt = A.getData("select count (*) from payment where DATEPART(M,payment_date)=DATEPART(M,GETDATE()) and DATEPART(YEAR,payment_date)=DATEPART(YEAR,GETDATE());");
            Profitlabel.Text = ddt.Rows[0][0].ToString();

            //calculate total income 
            DataTable fdt = A.getData("select count (*) from payment");
            label5.Text = fdt.Rows[0][0].ToString();

            //transparent value
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            Employeeslabel.BackColor = System.Drawing.Color.Transparent;
            Projectslabel.BackColor = System.Drawing.Color.Transparent;
            Profitlabel.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            timer1.Start();
        }

        private void timeLabel_Tick(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            datelabel.Text = DateTime.Now.ToString("MM dd yyyy");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
