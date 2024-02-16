using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_cc3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void medicationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._aarons_woodMedicalDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aarons_woodMedicalDataSet.Medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this._aarons_woodMedicalDataSet.Medications);

        }
    }
}
