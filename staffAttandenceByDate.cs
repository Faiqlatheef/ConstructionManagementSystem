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
    public partial class staffAttandenceByDate : Form
    {
        public staffAttandenceByDate()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void totalincome_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sdateTimePicker.Text != "" && edateTimePicker.Text != "")
                {
                    sDateText.Text = sdateTimePicker.Text;
                    eDateText.Text = edateTimePicker.Text;

                    // check from hire payment table
                    DataTable dt = A.getData("select * from staff_attandance where sa_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' ");
                    if (dt.Rows.Count > 0)
                    {
                        loadTable.DataSource = dt;
                    }

                }
                else
                {
                    MessageBox.Show("Check the Two dates ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
