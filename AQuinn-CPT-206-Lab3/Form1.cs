using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQuinn_CPT_206_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInfoDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            StateDetailscs stateDetails = new StateDetailscs();
            stateDetails.ShowDialog();
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.FillByViolet(this.stateInfoDataSet.States);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
        }

        
    }
}
