﻿using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
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
            A.appsFormLoadInsidePanel(new mainfrmcntnManager(), panel3);
        }

        private void homeLabel_Click_1(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new mainfrmcntnManager(), panel3);
        }

        private void staffsLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Staff(), panel3);
        }

        private void staffLeaveLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffLeave(), panel3);
        }

        private void staffPaymentLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffPayment(), panel3);
        }

        private void staffAttendanceLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffAttendanceView(), panel3);
        }

        private void clientLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Client(), panel3);
        }

        private void projectsLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new proje(), panel3);
        }

        private void totalIncomeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new totalincome(), panel3);
        }

        private void totalOutcomeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new totalcoast(), panel3);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new projectprosRep(), panel3);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffLeaveByDate(), panel3);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffAttandenceByDate(), panel3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffStatus(), panel3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new paymentMethod(), panel3);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffSearch(), panel3);
        }

        private void leaveTypeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new staffLeaveTypeByDate(), panel3);
        }

    }
}
