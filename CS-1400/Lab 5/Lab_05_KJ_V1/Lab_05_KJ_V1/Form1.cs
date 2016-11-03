//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 5
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

namespace Lab_05_KJ_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //start GUI
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n Cs1400_01\nLab #5"); // show about text
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close(); //terminate program
            
        }

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            const int DOUBLE = 2; //create constant that doubles
            int input = int.Parse(inputTextBox.Text); //create int that grabs text and converts to int
            int doubleInput = input * DOUBLE;  //Double the numbers
            string outString = $"{doubleInput:D}"; // create string
            outputTextBox.Text = outString; //output doubled string
        }
    }
}
/* Question 1:  const double DOUBLE = 2;
            double input = double.Parse(inputTextBox.Text);
            double doubleInput = input * DOUBLE; 
            string outString = $"{doubleInput:C}";
            outputTextBox.Text = outString;
Question 2 : double doubleInput = input / DOUBLE;
*/
