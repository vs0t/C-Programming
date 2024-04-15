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
    public partial class searchMenu : Form
    {
        public searchMenu()
        {
            InitializeComponent();
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void searchMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.usersDataSet.Menu);

        }

        private void searchNameBttn_Click(object sender, EventArgs e)
        {
            this.menuTableAdapter.SearchMenuName(this.usersDataSet.Menu, menuSearchBox.Text);
        }

        private void searchPriceBttn_Click(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(priceSearchBox.Text, out price))
            {
                this.menuTableAdapter.SearchMenuPrice(this.usersDataSet.Menu, price);
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal number.");
            }


        }

        private void searchDescBttn_Click(object sender, EventArgs e)
        {
            this.menuTableAdapter.SearchMenuDescription(this.usersDataSet.Menu, descriptionSearchBox.Text);

        }
    }
}
