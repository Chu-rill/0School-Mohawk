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

namespace Lab3B
{
    /// <summary>
    /// I, Churchill Daniel, 000983683 certify that this material is my original work.
    /// No other person's work has been used without due acknowledgement.
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// stores the price of every charged item from the listbox
        /// </summary>
        List<decimal> chargedPrices = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        /// <summary>
        /// Enables the Add Service button only when at least one service is selected.
        /// </summary>
        /// <param name="sender">The Services ListBox.</param>
        /// <param name="e">Event data.</param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.listbox.selectedindexcollection.count?view=windowsdesktop-10.0
            addServiceButton.Enabled = serviceListBox.SelectedIndices.Count > 0;
        }

        /// <summary>
        /// Returns the form to its original state.
        /// </summary>
        /// <param name="sender">The Reset button.</param>
        /// <param name="e">Event data.</param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            chargedPrices.Clear();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">The Exit button.</param>
        /// <param name="e">Event data.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds the selected services to the bill on first use it also adds the
        /// selected hairdresser, disables the hairdresser ComboBox and enables
        /// the Calculate Total Price button.
        /// </summary>
        /// <param name="sender">The Add Service button.</param>
        /// <param name="e">Event data.</param>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            
            if (serviceListBox.SelectedIndices.Count == 0) 
            {
                MessageBox.Show("Must have a service selected");
                return;
            }

            // add the hairdresser the the total price
            if (hairdresser.Enabled)
            {
                
                AddChargedItem(hairdresser.Text, GetHairdresserPrice());

                hairdresser.Enabled = false;
                totalPriceButton.Enabled = true;
            }

            // add all selected service to the total price
            foreach (int i in serviceListBox.SelectedIndices)
            {

                string service = serviceListBox.Items[i].ToString();
                AddChargedItem(service, GetServicePrice(service));
            }
            serviceListBox.ClearSelected();
            textBox1.Text = "";

        }

        /// <summary>
        /// Adds up every charged price and displays the total as a currency.
        /// </summary>
        /// <param name="sender">The Calculate Total Price button.</param>
        /// <param name="e">Event data.</param>
        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (decimal price in chargedPrices)
            {
                total += price;
            }
            textBox1.Text = total.ToString("C");
        }

        /// <summary>
        /// Adds an item to the Charged Items list, its price to the Price list,
        /// and stores the price for the total.
        /// </summary>
        /// <param name="name">Name of the hairdresser or service.</param>
        /// <param name="price">Price of the item.</param>
        private void AddChargedItem(string name, decimal price)
        {
            chargedListBox.Items.Add(name);
            priceListBox.Items.Add(price.ToString("C").PadLeft(10));
            chargedPrices.Add(price);
        }

        /// <summary>
        /// Gets the base rate of the hairdresser selected in the ComboBox.
        /// </summary>
        /// <returns>The hairdresser's base rate.</returns>
        private decimal GetHairdresserPrice()
        {
            switch (hairdresser.Text)
            {
                case "Jane Samley":
                    return 30m;
                case "Pat Johnson":
                    return 45m;
                case "Ron Chambers":
                    return 40m;
                case "Sue Pallon":
                    return 50m;
                default:
                    return 55m;
            }
        }

        /// <summary>
        /// Gets the rate for a service.
        /// </summary>
        /// <param name="service">Service name exactly as shown in the Services ListBox.</param>
        /// <returns>The service's rate, or a deafult value of 0</returns>
        private decimal GetServicePrice(string service)
        {
            switch (service)
            {
                case "Cut":
                    return 30m;
                case "Wash, blow-dry, and style":
                    return 20m;
                case "Colour":
                    return 40m;
                case "Highlights":
                    return 50m;
                case "Extensions":
                    return 200m;
                case "Up-do":
                    return 60m;
                default:
                    return 0m;
            }
        }

        /// <summary>
        /// Selects the first hairdresser, clears the charged items, prices and total,
        /// disables the Add Service and Calculate Total Price buttons, and sets focus
        /// to the hairdresser ComboBox.
        /// </summary>
        private void ResetForm()
        {
            hairdresser.Enabled = true;
            hairdresser.SelectedIndex = 0;

            serviceListBox.ClearSelected();
            chargedListBox.Items.Clear();
            priceListBox.Items.Clear();
            chargedListBox.Items.Clear();
            textBox1.Text = "";

            addServiceButton.Enabled = false;
            totalPriceButton.Enabled = false;

            hairdresser.Focus();
        }

        
    }
}
