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
    public partial class staffAttendance : Form
    {
        public staffAttendance()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();

        
        private void ClearDatafun()
        {
            staffIDBox.Text = "";

        }


        private void Login_Load(object sender, EventArgs e)
        {
            groupBoxStaffAttendance.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonStaffSubmit_Click(object sender, EventArgs e)
        {
            DateTime _datetime = DateTime.Now;
            string _id = staffIDBox.Text;
            try
            {
                //validate data to insert into table
                if (_id != "")
                {
                    A.insertData("insert into staff_attandance (sa_date,staff_fk) values ('" + _datetime + "', '" + _id + "' )");
                    this.ClearDatafun();
                }
                else
                {
                    MessageBox.Show(A.message_emptyBox());
                }
            }
            catch (Exception ex)
            {
                //exception results will show on label
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

    }
}
