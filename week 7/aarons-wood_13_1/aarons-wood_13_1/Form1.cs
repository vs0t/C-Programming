using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_13_1
{
    public partial class Form1 : Form
    {
        private List<int> integers = new List<int>();

        public Form1()
        {
            InitializeComponent();
            LoadIntegersFromFile();
        }

        private void LoadIntegersFromFile()
        {
            // clear the list and listbox to avoid duplicates
            integers.Clear();
            integerListBox.Items.Clear();

            // read integers from file and add to list
            try
            {
                using (StreamReader sr = new StreamReader("random.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            integers.Add(number);
                            integerListBox.Items.Add(number); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        private void negativeBttn_Click(object sender, EventArgs e)
        {
            // remove negative numbers
            for (int i = integerListBox.Items.Count - 1; i >= 0; i--)
            {
                if (int.TryParse(integerListBox.Items[i].ToString(), out int number) && number < 0)
                {
                    integerListBox.Items.RemoveAt(i); 
                }
            }

            integers.RemoveAll(n => n < 0);
        }

        private void findallBttn_Click(object sender, EventArgs e)
        {
            // clear and display only numbers in the range 1 through 10
            integerListBox.Items.Clear();
            foreach (int num in integers.FindAll(n => n >= 1 && n <= 10))
            {
                integerListBox.Items.Add(num);
            }
        }
    }
}
