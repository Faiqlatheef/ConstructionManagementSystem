using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDriveFinal
{
    public partial class mainFormAdmin : Form
    {
        public mainFormAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        CommonClass A = new CommonClass();
        private void homeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new mainfrmcntnAdmin(), panel3);
        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            new staffAttendance().Show();
            this.Hide();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new mainfrmcntnAdmin(), panel3);
        }

        private void homeLabel_Click_1(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new mainfrmcntnAdmin(), panel3);
        }

        private void staffsLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Staff(), panel3);
        }

        private void staffTypeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffType(), panel3);
        }

        private void staffPaymentLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffPayment(), panel3);
        }

        private void staffLeaveLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffLeave(), panel3);
        }

        private void clientLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Client(), panel3);
        }

        private void projectLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new proje(), panel3);
        }

        private void paymentLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Payment(), panel3);
        }
    }
}
