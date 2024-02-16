using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_cc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_aarons_woodMedicalDataSet11.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this._aarons_woodMedicalDataSet11.doctors);

        }
    }
}
