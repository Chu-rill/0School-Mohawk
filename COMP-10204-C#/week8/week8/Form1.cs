using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutHelpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app was made by.......", "About this app", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void redColorEditMenu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            redColorEditMenu.Checked = true;
            greenColorEditMenu.Checked = false;
            blueColorEditMenu.Checked = false;
        }

        private void greenColorEditMenu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            redColorEditMenu.Checked = false;
            greenColorEditMenu.Checked = true;
            blueColorEditMenu.Checked = false;
        }

        private void blueColorEditMenu_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Blue;
            redColorEditMenu.Checked = false;
            greenColorEditMenu.Checked = false;
            blueColorEditMenu.Checked = true;
        }
    }
}
