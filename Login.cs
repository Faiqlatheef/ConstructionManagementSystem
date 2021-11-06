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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HK99GPI\SQLEXPRESS;Initial Catalog=cmsdb;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select *from staffs where st_username = '" + idBox.Text + "' and st_password='" + passBox.Text + "'", con);
                DataTable dt = new DataTable(); //this is creating a virtual table 
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (userType.Text == "Admin")
                    {
                        this.Hide();
                        new mainFormAdmin().Show();
                    }
                    else
                    {
                        this.Hide();
                        new mainForm().Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void ClearDatafun()
        {
            idBox.Text = "";
            passBox.Text = "";

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            ClearDatafun();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            showPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
        }
        //Show Password
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passBox.UseSystemPasswordChar = false;
            }
            else
            {
                passBox.UseSystemPasswordChar = true;
            }
        }

    }
}
