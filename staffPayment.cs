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
    public partial class staffPayment : Form
    {
        public staffPayment()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _ID = idbox.Text;
            string _staff = staffIDcomboBox.SelectedValue.ToString();
            string _cashdate = paymentdateTime.Text;
            string _salary = salaryBox.Text;

            try
            {
                //validate data to update into table
                if (_ID != "" && _staff != "" && _salary != "" && _cashdate != "")
                {
                    A.updateData("update staff_payment set staff_id='" + _staff + "', month_salary='" + _salary + "', payment_date='" + _cashdate + "' where sp_id='" + _ID + "' ");
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
            string _staff = staffIDcomboBox.SelectedValue.ToString();
            string _cashdate = paymentdateTime.Text;
            string _salary = salaryBox.Text;

            try
            {
                //validate data to insert into table
                if (_staff != "" && _cashdate != "" && _salary != "")
                {
                    A.insertData("insert into staff_payment (staff_id,month_salary,payment_date) values ('" + _staff + "', '" + _salary + "', '" + _cashdate + "')");
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
            A.convertDateTimeFormate(paymentdateTime);
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
            staffIDcomboBox.DataSource = A.getData("select st_id as ID, st_name as Name, s_nic as NIC, st_mob as [Phone number], st_email as Email, st_address as Address, st_type as Type, salary as Salary, st_status as Status,st_username as Username from staffs ");
            staffIDcomboBox.DisplayMember = "ID";
            staffIDcomboBox.ValueMember = "ID";

            //auto complete
            this.staffIDcomboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.staffIDcomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        // this function for load table
        private void loadTableFun()
        {
            loadtable.DataSource = A.getData("select sp_id as ID, payment_date as Date, month_salary as [Monthly Salary], staff_id as [Staff] from staff_payment ");
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _ID = idbox.Text;

            try
            {
                //validate data to delete into table
                if (_ID != "")
                {
                    A.deleteData("Delete staff_payment where sp_id='" + _ID + "' ");
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


        // get staff payment data by id
        private DataTable getStaffPaymentDataByID(string _id)
        {
            return A.getData("select *from staff_payment where sp_id = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idbox.Text = "";
            staffIDcomboBox.SelectedIndex = 0;
            salaryBox.Text = "";
            paymentdateTime.Text = "";
        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }


        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadtable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idbox.Text = loadtable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getStaffPaymentDataByID(idbox.Text);

                staffIDcomboBox.SelectedValue = dt.Rows[0]["staff_id"].ToString();
                salaryBox.Text = dt.Rows[0]["month_salary"].ToString();
                paymentdateTime.Text = dt.Rows[0]["payment_date"].ToString();

            }
        }
    }
}
