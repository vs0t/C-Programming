using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_cc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aarons_woodMedicalDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this._aarons_woodMedicalDataSet.Patients);

        }

        private void listBttn_Click(object sender, EventArgs e)
        {
            patientsDataGridView.Visible = true;
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnName_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchName(this._aarons_woodMedicalDataSet.Patients, txtSearchName.Text);

        }

        private void bttnAddress_Click(object sender, EventArgs e)
        {
            

            this.patientsTableAdapter.SearchAddress(this._aarons_woodMedicalDataSet.Patients, txtSearchAddress.Text);
        }

        private void bttnPhone_Click(object sender, EventArgs e)
        {
            long phonetoSearch;
            long.TryParse(txtSearchPhone.Text, out phonetoSearch);
            this.patientsTableAdapter.SearchPhone(this._aarons_woodMedicalDataSet.Patients, phonetoSearch);
        }

        private void bttnEmail_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchEmail(this._aarons_woodMedicalDataSet.Patients, txtSearchEmail.Text);
        }

        private void bttnLimit_Click(object sender, EventArgs e)
        {
            decimal deductLimit;
            decimal.TryParse(txtSearchDeduct.Text, out deductLimit);
            this.patientsTableAdapter.SearchDeduc(this._aarons_woodMedicalDataSet.Patients, deductLimit);
        }
    }
}
