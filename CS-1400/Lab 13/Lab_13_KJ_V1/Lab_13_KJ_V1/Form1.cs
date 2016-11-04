//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 13
//Date: 09/26/16

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

namespace Lab_13_KJ_V1
{
    public partial class Form1 : Form
    {
        // a class level reference to a token machine
        private TokenMachine tm;
        public Form1()
        {
            InitializeComponent();
            // create a token machine object
            tm = new TokenMachine();
            tm.Reset();
            
        }
        // The AboutToolStrip Method
        // Purpose: Displays information about the creator
        // Parameters: None
        // Returns: Text
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n Lab 13\n CS1400_01");
        }
        // The ExitToolStrip Method
        // Purpose: Closes the aplication
        // Parameters: None
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The GetTokenBtn Method
        // Purpose: On click run the code that puts a coin in and gets a token out
        // Parameters: none
        // Returns: two strings through a text box
        private void GetTokenBtn_Click(object sender, EventArgs e)
        {
            tm.getQuarter();
            string countQuarterTxt = $"{tm.countQuarter()}";
            string countTokenTxt = $"{tm.countToken()}";
            numQuartersTxtBx.Text = countQuarterTxt;
            numTokensTxtBx.Text = countTokenTxt;
         }

        // The ResetBtn Method
        // Purpose: Resets all the values in the text boxes to original values
        // Parameters: None
        // Returns: two strings as text in the boxes
        private void ResetBtn_Click(object sender, EventArgs e)
        {

            tm.Reset();
            string countQuarterTxt = $"{tm.countQuarter()}";
            string countTokenTxt = $"{tm.countToken()}";
            numQuartersTxtBx.Text = countQuarterTxt;
            numTokensTxtBx.Text = countTokenTxt;
        }
    }
}
