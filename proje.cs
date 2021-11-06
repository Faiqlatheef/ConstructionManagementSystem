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
    public partial class proje : Form
    {
        public proje()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void projeLoad(object sender, EventArgs e)
        {
            loadTableFun();
            changeDateformat();
            loadClientComboBoxFun();

        }

        //Change Date format
        private void changeDateformat()
        {
            A.convertDateTimeFormate(startDateTime);
        }


        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _name = nameBox.Text;
            string _coast = coastBox.Text;
            string _status = statusComboBox.Text;
            string _sDate = startDateTime.Text;
            string _client = clientComboBox.SelectedValue.ToString();
            try
            {
                //validate data to insert into table
                if (_name != "" && _coast != "" && _status != "" && _sDate != "" && _client != "")
                {
                    A.insertData("insert into Project (p_name,p_cost,p_status,p_start_date,client_fk) values ('" + _name + "', '" + _coast + "', '" + _status + "', '" + _sDate + "', '" + _client + "' )");
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
                //exception results will show on label
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _name = nameBox.Text;
            string _coast = coastBox.Text;
            string _status = statusComboBox.Text;
            string _sDate = startDateTime.Text;
            string _client = clientComboBox.SelectedValue.ToString();

            try
            {
                //validate data to update into table
                if (_name != "" && _sDate != "" && _coast != "" && _status != "" && _client != "" && _id != "")
                {
                    A.updateData("update Project set  p_name='" + _name + "', p_cost='" + _coast + "', p_status='" + _status + "', p_start_date='" + _sDate + "', client_fk='" + _client + "' where p_id='" + _id + "' ");
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

        private void dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;

            try
            {
                //validate data to delete into table
                if (_id != "")
                {
                    A.deleteData("Delete Project where p_id='" + _id + "' ");
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

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select p_id as ID, p_name as Name, p_cost as Cost, p_status as [Project Status] , p_start_date as [Start Date],client_fk as Client from Project ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";
            coastBox.Text = "";
            statusComboBox.Text = "";
            startDateTime.Text = "";
            clientComboBox.SelectedIndex = 0;

        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // get Project by id
        private DataTable getProjectByID(string _id)
        {
            return A.getData("select *from Project where p_id = '" + _id + "' ");
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }

        // get Client info
        private void loadClientComboBoxFun()
        {
            clientComboBox.DataSource = A.getData("select c_id as ID, c_name as Name, c_nic as NIC, c_ph_no as [Phone number] , c_address as Address,c_email as Email from client ");
            clientComboBox.DisplayMember = "Name";
            clientComboBox.ValueMember = "ID";
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getProjectByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["c_name"].ToString();
                coastBox.Text = dt.Rows[0]["c_nic"].ToString();
                statusComboBox.Text = dt.Rows[0]["c_ph_no"].ToString();
                startDateTime.Text = dt.Rows[0]["c_address"].ToString();
                clientComboBox.SelectedValue = dt.Rows[0]["c_email"].ToString();

            }
        }

        private void proje_Load(object sender, EventArgs e)
        {
            loadTableFun();
            changeDateformat();
            loadClientComboBoxFun();
        }
    }
}
