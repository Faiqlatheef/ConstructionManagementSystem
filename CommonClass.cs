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
    class CommonClass
    {

        //commen variable
        SqlConnection conn = new SqlConnection(ConnectionClass.conn);
        public string message_emptyBox()
        {
            return "Empty Data is not acceptable...";
        }
        //this function for insert data into the database 
        public void insertData(string sql)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Contact with the IT department");
            }
        }
        //this function for update data into the database 
        public void updateData(string sql)
        {
           
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Contact with the IT department");
            }
        }
        //this function for delete data into the database 
        public void deleteData(string sql)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Contact with the IT department");
            }
        }
        //this function for veiw data
        public DataTable getData(string _sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(_sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public void convertDateTimeFormate(DateTimePicker _DateTimePicker)
        {
            _DateTimePicker.Format = DateTimePickerFormat.Custom;
            _DateTimePicker.CustomFormat = "yyyy/MM/dd";
        }

        //Display from inside panel 
        public void appsFormLoadInsidePanel(Form formName, Panel panelName)
        {
            //clear controls first
            panelName.Controls.Clear();
            //add controls
            formName.TopLevel = false;
            formName.AutoScroll = true;
            panelName.Controls.Add(formName);
            formName.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formName.Dock = DockStyle.Fill;
            formName.Show();
        }

    }

}
