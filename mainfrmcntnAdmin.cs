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
    public partial class mainfrmcntnAdmin : Form
    {
        public mainfrmcntnAdmin()
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
            ProjectsLabel.Text = rdt.Rows[0][0].ToString();


            //transparent value
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            Employeeslabel.BackColor = System.Drawing.Color.Transparent;
            ProjectsLabel.BackColor = System.Drawing.Color.Transparent;

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
    }
}
