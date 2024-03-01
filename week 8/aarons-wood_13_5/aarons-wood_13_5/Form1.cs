using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aarons_wood_13_5
{
    public partial class Form1 : Form
    {
        private List<DJIADay> djiaData = new List<DJIADay>();

        public Form1()
        {
            InitializeComponent();
            LoadDJIAData();
        }

        private void LoadDJIAData()
        {
            string filePath = Path.Combine(Application.StartupPath, "DJIA.csv");
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).Skip(1); // Assuming the first line is header
                foreach (var line in lines)
                {
                    djiaData.Add(new DJIADay(line));
                }
            }
            else
            {
                MessageBox.Show("DJIA.csv not found.");
            }
        }

        private void firstDateBttn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(firstDateBox.Text, out double targetValue))
            {
                var result = djiaData.FirstOrDefault(d => d.ClosingValue >= targetValue);
                numberListBox.Items.Clear();
                if (result != null)
                {
                    numberListBox.Items.Add($"Date: {result.Date.ToString("d-MMM-yyyy")}, Closing Value: {result.ClosingValue}");
                }
                else
                {
                    numberListBox.Items.Add("No matching date found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for closing value.");
            }
        }

        private void allDatesBttn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(allDatesBox.Text, out double targetValue))
            {
                var results = djiaData.Where(d => d.ClosingValue >= targetValue).ToList();
                numberListBox.Items.Clear();
                if (results.Any())
                {
                    foreach (var result in results)
                    {
                        numberListBox.Items.Add($"Date: {result.Date.ToString("d-MMM-yyyy")}, Closing Value: {result.ClosingValue}");
                    }
                }
                else
                {
                    numberListBox.Items.Add("No matching dates found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for closing value.");
            }
        }

        public class DJIADay
        {
            public DateTime Date { get; set; }
            public double ClosingValue { get; set; }
            public double OpeningValue { get; set; }
            public double High { get; set; }
            public double Low { get; set; }

            public DJIADay(string csvLine)
            {
                var parts = csvLine.Split(',');
                Date = DateTime.ParseExact(parts[0], "d-MMM-yy", CultureInfo.InvariantCulture);
                ClosingValue = double.Parse(parts[1]);
                OpeningValue = double.Parse(parts[2]);
                High = double.Parse(parts[3]);
                Low = double.Parse(parts[4]);
            }
        }
    }
}