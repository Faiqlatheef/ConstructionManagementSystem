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
    public partial class staffLeaveTypeByDate : Form
    {
        public staffLeaveTypeByDate()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void totalprofit_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchComboBox.Text != "" && sdateTimePicker.Text != "" && edateTimePicker.Text != "")
                {
                    typeLabel.Text = searchComboBox.Text;
                    sDateText.Text = sdateTimePicker.Text;
                    eDateText.Text = edateTimePicker.Text;

                    // check from Staff Leave
                    DataTable dt = A.getData("select * from staff_leave where sl_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and leave_type = '" + searchComboBox.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        loadTable.DataSource = dt;
                    }

                }
                else
                {
                    MessageBox.Show("Check the Two dates and combo Box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
