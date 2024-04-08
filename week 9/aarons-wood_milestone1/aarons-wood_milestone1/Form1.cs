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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void placeOrderBttn_Click(object sender, EventArgs e)
        {
            placeOrder placeOrderForm = new placeOrder();
            placeOrderForm.Show();
        }

        private void orderBttn_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBttn_Click(object sender, EventArgs e)
        {
            viewInventory viewInventoryForm = new viewInventory();
            viewInventoryForm.Show();
        }

        private void usersBttn_Click(object sender, EventArgs e)
        {
            viewUsers viewUsers = new viewUsers();
            viewUsers.Show();
        }

        private void menuBttn_Click(object sender, EventArgs e)
        {
            viewMenu viewMenuForm = new viewMenu(); // Create a new instance of the viewMenu form
            viewMenuForm.Show(); // Display the form
        }


        private void reportsBttn_Click(object sender, EventArgs e)
        {

        }

        private void tablesBttn_Click(object sender, EventArgs e)
        {
            addTable addTableForm = new addTable();
            addTableForm.Show();
        }
    }
}
