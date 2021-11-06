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
    public partial class paymentMethod : Form
    {
        public paymentMethod()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void topdriver_Load(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.Text == "Cash")
            {
                IdText.Text = typeComboBox.Text;
                DataTable dt = A.getData("SELECT * FROM payment WHERE payment_type = 'Cash' Desc");
                loadTable.DataSource = dt;
            }

            else if (typeComboBox.Text == "Cheque")
            {
                IdText.Text = typeComboBox.Text;
                DataTable dt = A.getData("SELECT * FROM payment WHERE payment_type = 'Cheque' Desc");
                loadTable.DataSource = dt;
            }
            
            else 
            {
                IdText.Text = typeComboBox.Text;
                DataTable dt = A.getData("SELECT * FROM payment WHERE payment_type = 'Card' Desc");
                loadTable.DataSource = dt;
            }
        }


    }
}
