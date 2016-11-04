//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 11
//Date: 09/17/16

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

namespace Lab_11_KJ_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // the ClearButton Method
        //purpose: Clear all text boxes
        private void ClearButton_Click(object sender, EventArgs e)
        {
            sideATxtBox.Clear();
            sideBTxtBox.Clear();
            sideCTxtBox.Clear();
        }
        // The CalcHypotenuse Method
        // Purpose: Takes data from the user and calculates the hypotenuse of a triangle
        // Parameters: two sides of a triangle as doubles
        // Returns: two sides of a triangle as doubles
        static double CalcHypotenuse(double side1, double side2)
        {
            // take side1 and Square it
            double side1SQ = Math.Pow(side1, 2);
            // save to side1SQ
            // take side 2 and square it
            double side2SQ = Math.Pow(side2, 2);
            // save to side1SQ
            // add together side1sq and side2sq
            double answerSQ = side1SQ + side2SQ;
            // save to answer
            // square root answer
            double total = Math.Sqrt(answerSQ);
            // return value 
            return total;
        }

        // The ExitToolStrip Method
        // Purpose: Closes the aplication
        // Parameters: None
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The AboutToolStrip Method
        // Purpose: Displays information about the creator
        // Parameters: None
        // Returns: Text
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\nLab 11\nCS1400_01");
        }
        // The CalculateButton Method
        // Purpose: runs the aplication
        // Parameters: None
        // Returns: Side C of the triangle
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //ask for side1 from user
            double side1 = double.Parse(sideATxtBox.Text);
            //ask for side2 from user
            double side2 = double.Parse(sideBTxtBox.Text);
            //run method CalcHypotenuse
            double total = CalcHypotenuse(side1, side2);
            //convert double to string
            string outPutTotal = $"{total:F2}";
            //output total
            sideCTxtBox.Text = outPutTotal;
        }
    }
}
