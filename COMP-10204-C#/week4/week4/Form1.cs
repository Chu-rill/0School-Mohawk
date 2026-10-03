using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text != String.Empty && lastNameTextBox.Text != String.Empty)
            {
                Person owner = new Person(firstNameTextBox.Text, lastNameTextBox.Text);
                BankAccountType type;
                if (chequingAccountRadioButton.Checked)
                {
                    type = BankAccountType.CHEQUING;
                }
                else
                {
                    type = BankAccountType.SAVINGS;
                }
               
                BankAccount account = new BankAccount(owner, type);
                accountInformationGroupBox.Enabled = true;
                clearAccountButton.Enabled = true;
                createAccountButton.Enabled = false;


                accountTextBox.Text = account.Number.ToString();
                currentBalanceTextBox.Text = $"{account.GetCurrentBalance():c}";
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Account Succesfully Created";
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Names must be filled in";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearAccountButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;

            createAccountButton.Enabled = true;
            clearAccountButton.Enabled = false;
            accountInformationGroupBox.Enabled = false;
            accountTextBox.Text = String.Empty;
            currentBalanceTextBox.Text = String.Empty;

        }
    }
}
