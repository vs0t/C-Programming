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
    public partial class searchOrders : Form
    {
        public searchOrders()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void searchOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);
            // TODO: This line of code loads data into the 'usersDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.usersDataSet.Order);

        }

        private void userIdBttn_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(this.userIdBox.Text, out userId))
            {
                this.orderTableAdapter.SearchUserID(this.usersDataSet.Order, userId);
            }
            else
            {
                // Handle the case when the input is not a valid integer
                MessageBox.Show("Please enter a valid user ID.");
            }
        }

        private void tableIdBttn_Click(object sender, EventArgs e)
        {
            int tableId;
            if (int.TryParse(this.tableIdBox.Text, out tableId))
            {
                this.orderTableAdapter.SearchTableID(this.usersDataSet.Order, tableId);
            } else
            {
                // Handle the case when the input is not a valid integer
                MessageBox.Show("Please enter a valid Table ID.");
            }
        }

        private void menuIdBttn_Click(object sender, EventArgs e)
        {
            int menuId;
            if (int.TryParse(this.menuIdBox.Text, out menuId))
            {
                this.orderTableAdapter.SearchMenuID(this.usersDataSet.Order, menuId);
            } else
            {
                // Handle the case when the input is not a valid integer
                MessageBox.Show("Please enter a valid Menu ID.");
            }
        }

        private void firstNameBttn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchUserFirstName(this.usersDataSet.Users, this.firstNameBox.Text);
        }

        private void lastNameBttn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchUserLastName(this.usersDataSet.Users, this.lastNameBox.Text);
        }
    }
}
