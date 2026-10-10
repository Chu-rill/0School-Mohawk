using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2B
{
    /// <summary>
    /// I, Churchill Daniel, 000983683 certify that this material is my original work.
    /// No other person's work has been used without due acknowledgement.
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hairDresserGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!checkCut.Checked && !checkColour.Checked && !checkHighlights.Checked && !checkExtensions.Checked)
            {
                totalPriceLabel.ForeColor = Color.Red;
                totalPriceLabel.Text = "Please select at least one service";
                checkCut.Focus();
                return;
            }

            int visits;

            if (!int.TryParse(visitTextBox.Text.Trim(), out visits) || visits <= 0)
            {
                totalPriceLabel.ForeColor = Color.Red;
                totalPriceLabel.Text = "Number of Client Visits must be greater than 0";
                visitTextBox.Focus();
                return;
            }

            decimal subtotal = GetBaseRate() + GetServiceTotal();
            decimal discountRate = GetDiscount() + GetVisitsDiscount(visits);
            decimal total = subtotal * (1 - discountRate);

            totalPriceLabel.ForeColor = Color.Green;
            totalPriceLabel.Text = total.ToString("C");

        }

        // <summary>
        /// Get the base cost based on the hairdresser
        /// </summary>
        private decimal GetBaseRate()
        {
            if (radJane.Checked)
            {
                return 30m;
            }
            else if (radPat.Checked)
            {
                return 45m;
            }
            else if (radRon.Checked)
            {
                return 40m;
            }
            else if (radSue.Checked)
            {
                return 50m;
            }
            else
            {
                return 55m;
            }
        }

        // <summary>
        /// Get the price for the total serivices being gotten
        /// </summary>
        private decimal GetServiceTotal()
        {
            decimal totalPrice = 0;
            if (checkCut.Checked)
            {
                totalPrice += 30m;
            }
            if (checkColour.Checked)
            {
                totalPrice += 40m;
            }
            if (checkHighlights.Checked)
            {
                totalPrice += 50m;
            }
            if (checkExtensions.Checked)
            {
                totalPrice += 200m;
            }
            return totalPrice;
        }

        // <summary>
        /// Get a discout based on the type of client
        /// </summary>
        private decimal GetDiscount()
        {
            if (radChild.Checked)
            {
                return 0.10m;
            }
            else if (radStudent.Checked)
            {
                return 0.05m;
            }
            else if (radSenior.Checked)
            {
                return 0.15m;
            }
            return 0;
        }

        // <summary>
        /// Get a discount for the total amount of visits
        /// </summary>
        private decimal GetVisitsDiscount(int visits)
        {
            if(visits >= 14)
            {
                return 0.15m;
            }
            else if (visits >= 9)
            {
                return 0.10m;
            }
            else if (visits >= 4)
            {
                return 0.05m;
            }
            return 0;
        }

        /// <summary>
        /// Resets the value of all the fields
        /// </summary>
        private void ResetForm()
        {
            // Uncheck all services
            checkCut.Checked = false;
            checkColour.Checked = false;
            checkHighlights.Checked = false;
            checkExtensions.Checked = false;

            // Clear inputs/outputs
            visitTextBox.Clear();
            totalPriceLabel.Text = string.Empty;

            // First radio button in each group
            radJane.Checked = true;
            radStandard.Checked = true;

            radJane.Focus();
        }
    }
}
