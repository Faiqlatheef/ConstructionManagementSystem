using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AyuboDriveFinal
{
    public partial class staffSearch : Form
    {
        public staffSearch()
        {
            InitializeComponent();
        }

        CommonClass A = new CommonClass();
        private void totalincome_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
            loadStaffComboBoxFun();
        }
        // get Staff info
        private void loadStaffComboBoxFun()
        {
            staffComboBox.DataSource = A.getData("select st_id as ID, st_name as Name, s_nic as NIC, st_mob as [Phone number], st_email as Email, st_address as Address, st_type as Type, salary as Salary, st_status as Status,st_username as Username from staffs ");
            staffComboBox.DisplayMember = "ID";
            staffComboBox.ValueMember = "ID";

            this.staffComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.staffComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffComboBox.Text != "")
                {

                    StaffIdText.Text = staffComboBox.Text;
                    areaLabel.Text = searchComboBox.Text;
                    sDateText.Text = sdateTimePicker.Text;
                    eDateText.Text = edateTimePicker.Text;

                    if (searchComboBox.Text == "Attandance")
                    {
                        // check from Staff Attandance
                        DataTable dt = A.getData("select * from staff_attandance where sa_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and staff_fk = '" + staffComboBox.SelectedValue + "'");
                        if (dt.Rows.Count > 0)
                        {
                            loadTable.DataSource = dt;
                        }
                    }
                    else if (searchComboBox.Text == "Leave")
                    {
                        // check from Staff Leave
                        DataTable dt = A.getData("select * from staff_leave where sl_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and staff_fk = '" + staffComboBox.SelectedValue + "'");
                        if (dt.Rows.Count > 0)
                        {
                            loadTable.DataSource = dt;
                        }
                    }
                    else
                    {
                        // check from Staff Attandance and Leave
                        DataTable dt = A.getData("select * from staff_attandance , staff_leave where staff_attandance.sa_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and staff_leave.sl_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and staff_attandance.staff_fk = '" + staffComboBox.SelectedValue + "' and staff_leave.staff_fk = '" + staffComboBox.SelectedValue + "'");
                        if (dt.Rows.Count > 0)
                        {
                            loadTable.DataSource = dt;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Staff ID ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

    }
}
