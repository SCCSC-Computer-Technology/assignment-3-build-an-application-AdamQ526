using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQuinn_CPT_206_Lab3
{
    public partial class StateDetailscs : Form
    {
        public StateDetailscs()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);

        }

        private void StateDetailscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInfoDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void populationTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (!int.TryParse(populationTextBox.Text,out int value)) {
                MessageBox.Show("invalid value entered in population text box!!!");
                populationTextBox.Text = "0";
                this.ActiveControl = stateIDTextBox;
            }


        }

        private void medianIncomeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(medianIncomeTextBox.Text, out double value)){
                MessageBox.Show("invalid value entered in median income text box!!!");
                medianIncomeTextBox.Text = "0.0";
                this.ActiveControl = stateIDTextBox;
            }
        }

        private void techJobsTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(techJobsTextBox.Text,out int value)){
                MessageBox.Show("invalid value entered in tech jobs text box!!!");
                techJobsTextBox.Text = "0";
                this.ActiveControl = stateIDTextBox;
            }
        }
    }
}
