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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();

        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idbox.Text;
            string _clnt = clntcomboBox.SelectedValue.ToString();
            string _project = projectIDcomboBox.SelectedValue.ToString();
            string _payType = payTypecomboBox.SelectedValue.ToString();
            string _pay = payTime.Text;
            string _amount = amountBox.Text; ;

            try
            {
                //validate data to update into table
                if (_id != "" && _clnt != "" && _project != "" && _payType != "" && _pay != "" && _amount != "")
                {
                    A.updateData("update payment set client_id='" + _clnt + "', Project_id='" + _project + "', payment_type='" + _payType + "', payment_date='" + _pay + "', payment_money='" + _amount + "' where pay_id='" + _id + "' ");
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

            string _clnt = clntcomboBox.SelectedValue.ToString();
            string _project = projectIDcomboBox.SelectedValue.ToString();
            string _payType = payTypecomboBox.Text;
            string _pay = payTime.Text;
            string _amount = amountBox.Text;

            try
            {
                //validate data to insert into table
                if (_clnt != "" && _project != "" && _payType != "" && _pay != "" && _amount != "")
                {
                    A.insertData("insert into payment (client_id,Project_id,payment_type,payment_date,payment_money) values ('" + _clnt + "', '" + _project + "', '" + _payType + "', '" + _pay + "', '" + _amount + "')");


                    billDisplayBox.AppendText("Payment (CMS)" +
                        Environment.NewLine +
                        " ------------------------------ " +
                        Environment.NewLine + " Client : " + _clnt +
                        Environment.NewLine + " Project : " + _project +
                        Environment.NewLine + " Payment Type  : " + _payType +
                        Environment.NewLine + " Payment Date :" + _pay +
                        Environment.NewLine + " Payment Amount :" + _amount);

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
            A.convertDateTimeFormate(payTime);
        }
        private void payment_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadClientComboBoxFun();
            loadProjectComboBoxFun();
            changeDateformat();
        }
        // get Client info
        private void loadClientComboBoxFun()
        {
            clntcomboBox.DataSource = A.getData("select c_id as ID, c_name as Name, c_nic as NIC, c_ph_no as [Phone number] , c_address as Address,c_email as Email from client ");
            clntcomboBox.DisplayMember = "ID";
            clntcomboBox.ValueMember = "ID";
        }

        // get project info
        private void loadProjectComboBoxFun()
        {
            projectIDcomboBox.DataSource = A.getData("select p_id as ID, p_name as Name, p_cost as cost, p_status as status, p_start_date as [Start Date],client_fk as Client from Project ");
            projectIDcomboBox.DisplayMember = "ID";
            projectIDcomboBox.ValueMember = "ID";
        }

        // this function for load table
        private void loadTableFun()
        {
            loadtable.DataSource = A.getData("select pay_id as ID, client_id as [Client ID], Project_id as [Project ID], payment_type as [Payment Type],payment_date as Date, payment_money as [Amount] from payment  ");
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
                    A.deleteData("Delete payment where pay_id='" + _ID + "' ");
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

        private void loadtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // get payment data by id
        private DataTable getpaymentDataByID(string _id)
        {
            return A.getData("select *from payment where pay_id = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idbox.Text = "";
            clntcomboBox.SelectedIndex = 0;
            projectIDcomboBox.SelectedIndex = 0;
            payTypecomboBox.Text = "";
            payTime.Text = "";
            amountBox.Text = "";
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
                DataTable dt = getpaymentDataByID(idbox.Text);

                clntcomboBox.SelectedValue = dt.Rows[0]["client_id"].ToString();
                projectIDcomboBox.SelectedValue = dt.Rows[0]["Project_id"].ToString();
                payTypecomboBox.SelectedValue = dt.Rows[0]["payment_type"].ToString();
                payTime.Text = dt.Rows[0]["payment_date"].ToString();
                amountBox.Text = dt.Rows[0]["payment_money"].ToString();

            }
        }

        private void prntbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(billDisplayBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 100));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Payment_Load_1(object sender, EventArgs e)
        {
            loadTableFun();
            loadClientComboBoxFun();
            loadProjectComboBoxFun();
            changeDateformat();
        }
    }
}
