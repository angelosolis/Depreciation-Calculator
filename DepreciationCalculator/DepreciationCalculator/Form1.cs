using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void CalculateSLN(double initialCost, double salvageValue, int usefulLife)
        {
            double depreciation = (initialCost - salvageValue) / usefulLife;
            double bookValue = initialCost;
            listBoxDepreciation.Items.Add(string.Format("{0,-10} {1,-20} {2,-20}", "Year", "Depreciation", "Book Value"));
            for (int year = 1; year <= usefulLife; year++)
            {
                bookValue -= depreciation;
                listBoxDepreciation.Items.Add(string.Format("{0,-15} {1,-20:C2} {2,-20:C2}", year, depreciation, bookValue));
            }
        }

        private void CalculateSYD(double initialCost, double salvageValue, int usefulLife)
        {
            int sumOfYearsDigits = (usefulLife * (usefulLife + 1)) / 2;
            double bookValue = initialCost;
            listBoxDepreciation.Items.Add(string.Format("{0,-10}{1,-20}{2,-20}", "Year", "Depreciation", "Book Value"));
            for (int year = 1; year <= usefulLife; year++)
            {
                double depreciation = (initialCost - salvageValue) * (usefulLife - year + 1) / sumOfYearsDigits;
                bookValue -= depreciation;
                listBoxDepreciation.Items.Add(string.Format("{0,-15}{1,-20:C2}{2,-20:C2}", year, depreciation, bookValue));
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double initialCost = double.Parse(txtInitialCost.Text);
                double salvageValue = double.Parse(txtSalvageValue.Text);
                int usefulLife = int.Parse(cbLife.SelectedItem.ToString());

                listBoxDepreciation.Items.Clear();

                if (radioButtonSLN.Checked)
                {
                    CalculateSLN(initialCost, salvageValue, usefulLife);
                }
                else if (radioButtonSYD.Checked)
                {
                    CalculateSYD(initialCost, salvageValue, usefulLife);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
