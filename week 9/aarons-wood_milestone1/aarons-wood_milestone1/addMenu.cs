using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_milestone1
{
    public partial class addMenu : Form
    {
        public addMenu()
        {
            InitializeComponent();
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void addMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.usersDataSet.Menu);

        }
    }
}
