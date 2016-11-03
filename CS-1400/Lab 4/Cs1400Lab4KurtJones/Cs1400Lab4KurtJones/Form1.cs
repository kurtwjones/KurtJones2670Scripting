//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 4
//Date: 09/02/16

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
//---------------------------------------------------------------------------


using System;   
using System.Windows.Forms;

namespace Cs1400Lab4KurtJones       //open namespace
{
    public partial class Form1 : Form       //open Class
    {
        public Form1()      
        {
            InitializeComponent(); //start form
        }
        // The exitToolStripMenuItem1 method
        // Purpose: To close the window and terminate the application
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) //creates tab exit
        {
            this.Close();       //Command to Close Window
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)   //creates tab about
        {
            MessageBox.Show("Kurt Jones\nCS1400_01\nLab#4"); //Command to display about text
        }
    }        //close Class
}       //close namespace
// Question 1: (C)
// Question 2: (B)
