//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 17
//Date: 10/01/16

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
//---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_17_KJ_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The StandardShipBtn Method
        // Purpose: Allows Selection of shipping method
        // Parameters: None
        // Returns: Text
        private void StandardShipBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardShipBtn.Checked)
            {
                MessageBox.Show("You have selected Standard Shipping.");
            }
        }
        // The ExpressShipBtn Method
        // Purpose: Allows you to select shipping method
        // Parameters: None
        // Returns: Text
        private void ExpressShipBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ExpressShipBtn.Checked)
            {
                MessageBox.Show("You have selected Express Shipping.");
            }
        }
        // The SameDayShipBtn Method
        // Purpose: Allows you to choose a shipping method
        // Parameters: None
        // Returns: Text
        private void SameDayShipBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SameDayShipBtn.Checked)
            {
                MessageBox.Show("You have selected Same-Day Shipping");
            }
        }
        // The AboutToolStrip Method
        // Purpose: Displays information about the creator
        // Parameters: None
        // Returns: Text
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n Lab 17\n CS 1400_01");
        }
        // The ExitToolStrip Method
        // Purpose: Closes the Window and terminates the program.
        // Parameters: None
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//Question 1: string Text = comboBox.Text
//Question 2: int selectedItem = comboBox.SelectedIndex;
