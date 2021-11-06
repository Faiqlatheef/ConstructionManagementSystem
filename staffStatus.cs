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
    public partial class staffStatus : Form
    {
        public staffStatus()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void topdriver_Load(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.Text == "Active")
            {
                IdText.Text = typeComboBox.Text;
                DataTable dt = A.getData("SELECT * FROM staffs WHERE status = 'Active' Desc");
                loadTable.DataSource = dt;
            }
            
            else 
            {
                IdText.Text = typeComboBox.Text;
                DataTable dt = A.getData("SELECT * FROM staffs WHERE status = 'Deactive' Desc");
                loadTable.DataSource = dt;
            }
        }


    }
}
