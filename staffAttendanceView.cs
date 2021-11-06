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
    public partial class staffAttendanceView : Form
    {
        public staffAttendanceView()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();


        private void Login_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }

        // this function for load table
        private void loadTableFun()
        {
            loadtable.DataSource = A.getData("select sa_id as ID, sa_date as Date, staff_fk as [Staff] from staff_attandance ");
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            string _srch = srchBox.Text;

            loadtable.DataSource = A.getData("select * from staff_attandance where sa_id='" + _srch + "'  ");
        }
        

    }
}
