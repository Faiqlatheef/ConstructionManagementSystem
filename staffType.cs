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
    public partial class staffType : Form
    {
        public staffType()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _ID = idbox.Text;
            string _stafType = stafTypeBox.Text;

            try
            {
                //validate data to update into table
                if (_ID != "" && _stafType != "")
                {
                    A.updateData("update staff_type set st_name='" + _stafType + "' where st_id='" + _ID + "' ");
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
            string _stafType = stafTypeBox.Text;

            try
            {
                //validate data to insert into table
                if (_stafType != "")
                {
                    A.insertData("insert into staff_type (st_name) values ('" + _stafType + "')");
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
        
        private void Cash_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }

        // this function for load table
        private void loadTableFun()
        {
            loadtable.DataSource = A.getData("select st_id as ID, st_name as [Staff Type] from staff_type");
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
                    A.deleteData("Delete staff_type where st_id='" + _ID + "' ");
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
                DataTable dt = getCashDataByID(idbox.Text);

                stafTypeBox.Text = dt.Rows[0]["st_name"].ToString();

            }
        }

        // get vehicle data by id
        private DataTable getCashDataByID(string _id)
        {
            return A.getData("select * from staff_type where st_id = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idbox.Text = "";
            stafTypeBox.Text = "";
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
