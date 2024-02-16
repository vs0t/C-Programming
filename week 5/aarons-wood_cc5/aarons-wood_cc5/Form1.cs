using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_cc5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._aarons_woodMedicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aarons_woodMedicalDataSet.patientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this._aarons_woodMedicalDataSet.patientInfo);

        }

        private void bttnHeight_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByDescHeight(this._aarons_woodMedicalDataSet.patientInfo);

        }

        private void bttnWeight200_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByWeightOver(this._aarons_woodMedicalDataSet.patientInfo);

        }

        private void bttnWeight100_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByWeightUnder(this._aarons_woodMedicalDataSet.patientInfo);

        }

        private void bttnAlc_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByAlcOver(this._aarons_woodMedicalDataSet.patientInfo);
        }

        private void bttnAge_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByAgeOver(this._aarons_woodMedicalDataSet.patientInfo);
        }
    }
}
