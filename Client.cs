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
using System.Net;
using System.Net.Mail;

namespace AyuboDriveFinal
{
    public partial class Client : Form
    {
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        public Client()
        {
            InitializeComponent();
        }

        private void Savebtn_Click_1(object sender, EventArgs e)
        {
            
            //get insert values from text box into variable

            string _name = nameBox.Text;
            string _nic = nicBox.Text;
            string _mob = mobnoBox.Text;
            string _add = addressBox.Text;
            string _mail = mailBox.Text;
            try
            {
                //validate data to insert into table
                if (_name != "" && _nic != "" && _mob != "" && _add != "" && _mail != "" && isValid())
                {
                    A.insertData("insert into client (c_name,c_nic,c_ph_no,c_address,c_email) values ('" + _name + "', '" + _nic + "', '" + _mob + "', '" + _add + "', '" + _mail + "' )");
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
            string _nic = nicBox.Text;
            string _mob = mobnoBox.Text;
            string _add = addressBox.Text;
            string _mail = mailBox.Text;

            try
            {
                //validate data to update into table
                if (_name != "" && _add != "" && _nic != "" && _mob != "" && _mail != "" && _id != "" && isValid())
                {
                    A.updateData("update client set  c_name='" + _name + "', c_nic='" + _nic + "', c_ph_no='" + _mob + "', c_address='" + _add + "', c_email='" + _mail + "' where c_id='" + _id + "' ");
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

        private void dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;

            try
            {
                //validate data to delete into table
                if (_id != "")
                {
                    A.deleteData("Delete client where c_id='" + _id + "' ");
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

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select c_id as ID, c_name as Name, c_nic as NIC, c_ph_no as [Phone number] , c_address as Address,c_email as Email from client ");
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";
            nicBox.Text = "";
            mobnoBox.Text = "";
            addressBox.Text = "";
            mailBox.Text = "";
            
        }



        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // get Client by id
        private DataTable getClientByID(string _id)
        {
            return A.getData("select *from client where c_id = '" + _id + "' ");
        }

        private void loadTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getClientByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["c_name"].ToString();
                nicBox.Text = dt.Rows[0]["c_nic"].ToString();
                mobnoBox.Text = dt.Rows[0]["c_ph_no"].ToString();
                addressBox.Text = dt.Rows[0]["c_address"].ToString();
                mailBox.Text = dt.Rows[0]["c_email"].ToString();

            }
        }

        private void clrbtn_Click_1(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            string _srch = srchBox.Text;

            loadTable.DataSource = A.getData("select * from client where c_id='" + _srch + "'  ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Client_Load_1(object sender, EventArgs e)
        {
            loadTableFun();
        }
        //Validations
        private bool isValid()
        {
            if (commonValidations.Valid_Name.IsMatch(nameBox.Text) != true)
            {
                MessageBox.Show("Name accepts only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameBox.Focus();
                return false;
            }
            else if (commonValidations.Valid_Name_Limit.IsMatch(nameBox.Text) != true)
            {
                MessageBox.Show("Name should be upto 6 alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameBox.Focus();
                return false;
            }
            else if (commonValidations.Valid_Nic.IsMatch(nicBox.Text) != true)
            {
                MessageBox.Show("Please enter valid Nic format ex: 970941991V", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nicBox.Focus();
                return false;
            }
            else if (commonValidations.Valid_Phoeno.IsMatch(mobnoBox.Text) != true)
            {
                MessageBox.Show("Please enter valid Mobile Number format ex: 77XXXXXXX", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mobnoBox.Focus();
                return false;
            }
            else if (commonValidations.Valid_Email.IsMatch(mailBox.Text) != true)
            {
                MessageBox.Show("Please enter valid email format ex: faiq.fq@gmail.com", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mailBox.Focus();
                return false;
            }
            return true;
        }


        //Email message to Client after registration
        public void Email()
        {
            MailAddress to = new MailAddress(mailBox.Text);
            MailAddress from = new MailAddress("sourcec19@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "New Client Registration to Our Company";
            message.Body = "Name : " + nameBox.Text + "  NIC : " + nicBox.Text + " Email: " + mailBox.Text;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("sourcec19@gmail.com", "*3Source@321$"),
                EnableSsl = true
            };
            // code in brackets above needed if authentication required 
            try
            {
                client.Send(message);
                MessageBox.Show("Maill Sended");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        
    }
}
