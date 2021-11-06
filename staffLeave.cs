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
    public partial class staffLeave : Form
    {
        public staffLeave()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _staff = staffcomboBox.SelectedValue.ToString();
            string _LeaveType = LeaveTypecomboBox.Text;
            string _staffaLeave = staffaLeavedateTime.Text;
            string _reason = reasonBox.Text;
            string _sl_id = idbox.Text;

            try
            {
                //validate data to update into table
                if (_staff != "" && _staffaLeave != "" && _reason != "" && _sl_id != "" && _LeaveType != "")
                {
                    A.updateData("update staff_leave set sl_date='" + _staffaLeave + "', sl_reason='" + _reason + "', staff_fk='" + _staff + "', leave_type='" + _LeaveType + "' where sl_id='" + _sl_id + "' ");
                    loadTableFun();
                    this.ClearDatafun();
                }
                else
                {
                    MessageBox.Show(A.message_emptyBox());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _staff = staffcomboBox.SelectedValue.ToString();
            string _LeaveType = LeaveTypecomboBox.Text;
            string _staffaLeave = staffaLeavedateTime.Text;
            string _reason = reasonBox.Text;

            try
            {
                //validate data to insert into table
                if (_staffaLeave != "" && _staff != "" && _reason != "" && _LeaveType != "")
                {
                    A.insertData("insert into staff_leave (sl_date,sl_reason,staff_fk,leave_type) values ('" + _staffaLeave + "', '" + _reason + "', '" + _staff + "', '" + _LeaveType + "')");
                    loadTableFun();
                    this.ClearDatafun();
                }
                else
                {
                    MessageBox.Show(A.message_emptyBox());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        private void changeDateformat()
        {
            A.convertDateTimeFormate(staffaLeavedateTime);
        }
        private void Cash_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadStaffComboBoxFun();
            changeDateformat();
        }
        // get Staff info
        private void loadStaffComboBoxFun()
        {
            staffcomboBox.DataSource = A.getData("select st_id as ID, st_name as Name, s_nic as NIC, st_mob as [Phone number], st_email as Email, st_address as Address, st_type as Type, salary as Salary, st_status as Status,st_username as Username from staffs ");
            staffcomboBox.DisplayMember = "ID";
            staffcomboBox.ValueMember = "ID";

            //auto complete
            this.staffcomboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.staffcomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        // this function for load table
        private void loadTableFun()
        {
            loadtable.DataSource = A.getData("select sl_id as ID, sl_date as Date, sl_reason as [Leave Reason], staff_fk as [Staff], leave_type as [Leave Type] from staff_leave ");
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _sl_id = idbox.Text;

            try
            {
                //validate data to delete into table
                if (_sl_id != "")
                {
                    A.deleteData("Delete staff_leave where sl_id='" + _sl_id + "' ");
                    loadTableFun();
                    this.ClearDatafun();
                }
                else
                {
                    MessageBox.Show(A.message_emptyBox());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void loadtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idbox.Text = loadtable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getStaffLeaveDataByID(idbox.Text);

                staffcomboBox.SelectedValue = dt.Rows[0]["staff_fk"].ToString();
                staffaLeavedateTime.Text = dt.Rows[0]["sl_date"].ToString();
                reasonBox.Text = dt.Rows[0]["sl_reason"].ToString();
                LeaveTypecomboBox.Text = dt.Rows[0]["leave_type"].ToString();

            }
        }

        // get Staff Leave data by id
        private DataTable getStaffLeaveDataByID(string _id)
        {
            return A.getData("select *from staff_leave where sl_id = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idbox.Text = "";
            staffcomboBox.SelectedIndex = 0;
            staffaLeavedateTime.Text = "";
            LeaveTypecomboBox.Text = "";
            reasonBox.Text = "";

        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }


        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
