//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 6
//Date: 09/02/16

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

namespace Lab_06_KJ_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Start GUI
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Show information about the creator
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n CS1400_01\n Lab #6");
        }
        // the clearButton_Click method
        //Purpose : To Clear the text boxes of all information
        //Returns : None
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputDiamater.Clear();
            outputTurnsPerMile.Clear();
        }
        // The exitToolStripMenuItem1 method
        // Purpose: To close the window and terminate the application
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // Purpose: Calculate turns per mile and output a string into the output textbox
        private void inputDiamater_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void inputDiamater_Leave(object sender, EventArgs e)
        {
            // Create Constant for PI (3.14)
            const double PI = 3.14;
            // create Constant for inchesPerMile (63,360)
            const double inchesPerMile = 63360;
            // Get string from inputDiamater box
            double input = double.Parse(inputDiamater.Text);
            // Convert string to Double
            // Take Double and times by PI and call it Circumference
            double circumference = input * PI;
            // Divide inchesPerMile to Circumferance
            double newCircumference = inchesPerMile / circumference;
            // output revolutionsPerMile
            string outStr = $"{newCircumference}";
            outputTurnsPerMile.Text = outStr;
            
        }
    }
}
// Question 1: 75.36 inches 
// question 2: circ = diam * PI;
//              const PI = 3.14