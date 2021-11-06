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
    public partial class projectprosRep : Form
    {
        public projectprosRep()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void topdriver_Load(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (typeComboBox.Text == "On Going")
                {
                    IdText.Text = typeComboBox.Text;
                    DataTable dt = A.getData("SELECT * FROM Project WHERE p_status = 'On Going' ");
                    loadTable.DataSource = dt;
                }
                else if (typeComboBox.Text == "Droped")
                {
                    IdText.Text = typeComboBox.Text;
                    DataTable dt = A.getData("SELECT * FROM Project WHERE p_status = 'Droped' ");
                    loadTable.DataSource = dt;
                }
                else
                {
                    IdText.Text = typeComboBox.Text;
                    DataTable dt = A.getData("SELECT * FROM Project WHERE p_status = 'Finished' ");
                    loadTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


    }
}
