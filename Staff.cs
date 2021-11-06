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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        //this object is created for get common code for this application
        CommonClass A = new CommonClass();


        private void Staff_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }

        

        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // get Staff data by id
        private DataTable getStaffDataByID(string _id)
        {
            return A.getData("select *from staffs where st_id = '" + _id + "' ");
        }

        //validate data funtion
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
            else if (commonValidations.Valid_Email.IsMatch(emailBox.Text) != true)
            {
                MessageBox.Show("Please enter valid email format ex: faiq.fq@gmail.com", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailBox.Focus();
                return false;
            }
            return true;
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";
            nicBox.Text = "";
            mobnoBox.Text = "";
            emailBox.Text = "";
            addBox.Text = "";
            typecomboBox.Text = "";
            salaryBox.Text = "";
            statuscomboBox.Text = "";
            unameBox.Text = "";
            passwordBox.Text = "";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _name = nameBox.Text;
            string _nic = nicBox.Text;
            string _mob = mobnoBox.Text;
            string _email = emailBox.Text;
            string _add = addBox.Text;
            string _type = typecomboBox.Text;
            string _salary = salaryBox.Text;
            string _status = statuscomboBox.Text;
            string _uname = unameBox.Text;
            string _password = passwordBox.Text;

            try
            {
                //validate data to insert into table
                if (_name != "" && _nic != "" && _mob != "" && _add != "" && _email != "" && _type != "" && _salary != "" && _status != "" && isValid())
                {
                    A.insertData("insert into staffs (st_name,s_nic,st_mob,st_email,st_address,st_type,salary,st_status,st_username,st_password) values ('" + _name + "', '" + _nic + "', '" + _mob + "', '" + _email + "', '" + _add + "','" + _type + "', '" + _salary + "', '" + _status + "', '" + _uname + "', '" + _password + "' )");
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

        private void clrbtn_Click_1(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }

        private void updbtn_Click_1(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _name = nameBox.Text;
            string _nic = nicBox.Text;
            string _mob = mobnoBox.Text;
            string _email = emailBox.Text;
            string _add = addBox.Text;
            string _type = typecomboBox.Text;
            string _salary = salaryBox.Text;
            string _status = statuscomboBox.Text;
            string _uname = unameBox.Text;
            string _password = passwordBox.Text;

            try
            {
                //validate data to update into table
                if (_name != "" && _nic != "" && _mob != "" && _add != "" && _email != "" && _type != "" && _salary != "" && _status != "" && _id != "" && isValid())
                {
                    A.updateData("update staffs set  st_name='" + _name + "', s_nic='" + _nic + "', st_mob='" + _mob + "', st_email='" + _email + "', st_address='" + _add + "', st_type='" + _type + "', salary='" + _salary + "', st_status='" + _status + "', st_username='" + _uname + "', st_password='" + _password + "' where st_id='" + _id + "' ");
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

        private void dltbtn_Click_1(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;

            try
            {
                //validate data to delete into table
                if (_id != "")
                {
                    A.deleteData("Delete staffs where st_id='" + _id + "' ");
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
            loadTable.DataSource = A.getData("select st_id as ID, st_name as Name, s_nic as NIC, st_mob as [Phone number], st_email as Email, st_address as Address, st_type as Type, salary as Salary, st_status as Status,st_username as Username from staffs ");
        }

        private void loadTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getStaffDataByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["st_name"].ToString();
                nicBox.Text = dt.Rows[0]["s_nic"].ToString();
                mobnoBox.Text = dt.Rows[0]["st_mob"].ToString();
                emailBox.Text = dt.Rows[0]["st_email"].ToString();
                addBox.Text = dt.Rows[0]["st_address"].ToString();
                typecomboBox.Text = dt.Rows[0]["st_type"].ToString();
                salaryBox.Text = dt.Rows[0]["salary"].ToString();
                statuscomboBox.Text = dt.Rows[0]["st_status"].ToString();
                unameBox.Text = dt.Rows[0]["st_username"].ToString();
                passwordBox.Text = dt.Rows[0]["st_password"].ToString();

            }
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            string _srch = srchBox.Text;

            loadTable.DataSource = A.getData("select * from staffs where st_id='" + _srch + "'  ");
        }

        private void Staff_Load_1(object sender, EventArgs e)
        {
            loadTableFun();
            loadStaffComboBoxFun();
        }

        //Email message to staffs after registration
        public void Email()
        {
            MailAddress to = new MailAddress(emailBox.Text);
            MailAddress from = new MailAddress("sourcec19@gmail.com");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "You have now successfully registered as a employee to '" + typecomboBox.SelectedItem + "' position";
            message.Body = "Name : " + nameBox.Text + "  NIC : " + nicBox.Text + " Email: " + emailBox.Text + "Salary:" + salaryBox.Text;

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
        // get Staff Type info
        private void loadStaffComboBoxFun()
        {
            typecomboBox.DataSource = A.getData("select st_id as ID, st_name as [Staff Type] from staff_type");
            typecomboBox.DisplayMember = "ID";
            typecomboBox.ValueMember = "ID";

            //auto complete
            this.typecomboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.typecomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

             

   }
}
