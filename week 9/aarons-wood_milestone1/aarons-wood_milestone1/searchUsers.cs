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
    public partial class searchUsers : Form
    {
        public searchUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void searchUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

        }

        private void searchFirstNameBttn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchUserFirstName(this.usersDataSet.Users, firstNameBox.Text);

        }

        private void searchLastNameBttn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchUserLastName(this.usersDataSet.Users, lastNameBox.Text);
        }

        private void searchEmailBttn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchUserEmail(this.usersDataSet.Users, emailBox.Text);
        }

        private void searchPhoneBttn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchUserPhone(this.usersDataSet.Users, phoneBox.Text);
        }
    }
}
