using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
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

        private void firstTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double value1, value2;
            if (double.TryParse(firstTextBox.Text, out value1) && double.TryParse(secondTextBox.Text, out value2))
            {
                resultTextBox.Text = (value1 - value2).ToString();
            }
            else
                resultTextBox.Text = "Only Numbers Allowed";


        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            string temp = firstTextBox.Text;
            firstTextBox.Text = secondTextBox.Text;
            secondTextBox.Text = temp;
         

            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstTextBox.Clear();
            secondTextBox.Text= "";
            resultTextBox.Text = string.Empty;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
