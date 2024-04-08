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
    public partial class viewMenu : Form
    {
        public viewMenu()
        {
            InitializeComponent();
        }



        private void editDeleteBttn_Click(object sender, EventArgs e)
        {
            addMenu addMenuForm = new addMenu(); // Create a new instance of the addMenu form
            addMenuForm.Show(); // Display the form
        }




        private void viewMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.usersDataSet.Menu);

        }
    }
}
