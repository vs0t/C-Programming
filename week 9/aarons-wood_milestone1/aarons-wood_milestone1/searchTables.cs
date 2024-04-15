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
    public partial class searchTables : Form
    {
        public searchTables()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void searchTables_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.usersDataSet.Table);

        }

        private void userIdBttn_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(userIdBox.Text, out userId))
            {
                this.tableTableAdapter.SearchUserID(this.usersDataSet.Table, userId);
            }
            else
            {
                // Handle invalid input
                MessageBox.Show("Please enter a valid user ID.");
            }
        }

        private void countBttn_Click(object sender, EventArgs e)
        {
            int seatCount;
            if (int.TryParse(countBox.Text, out seatCount))
            {
                this.tableTableAdapter.SearchSeatCount(this.usersDataSet.Table, seatCount);
            }
            else
            {
                // Handle invalid input
                MessageBox.Show("Please enter a valid seat count.");
            }
        }
    }
}
