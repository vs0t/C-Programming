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
    public partial class searchInventory : Form
    {
        public searchInventory()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void searchInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.usersDataSet.Inventory);

        }

        private void nameBttn_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.SearchInventoryName(this.usersDataSet.Inventory, nameBox.Text);
        }

        private void priceBttn_Click(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(priceBox.Text, out price))
            {
                this.inventoryTableAdapter.SearchInventoryPrice(this.usersDataSet.Inventory, price);
            }
            else
            {
                // Handle the case when the input is not a valid decimal
                MessageBox.Show("Please enter a valid price.");
            }
        }
    }
}
