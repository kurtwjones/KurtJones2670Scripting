//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: project 1
//Date: 09/06/16

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

namespace Project_01_KJ_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //purpose: Outputs information about creator
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n Project 1\n CS1400_01");
        }

        //purpose: Terminates program
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //purpose: Clear All Text Boxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            costOfMealBox.Clear();
            poorServiceBox.Clear();
            goodServiceBox.Clear();
            excellentServiceBox.Clear();
        }
        //purpose: Calculate tip from 3 types of service

        private void costOfMealBox_Leave(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create constant for poor, good and excellent service
            const double POOR = .10;
            const double GOOD = .15;
            const double EXCELLENT = .20;
            // take amount of meal and convert to double
            double totalMeal = double.Parse(costOfMealBox.Text);
            // take amount of meal and devide by poor service
            double tipPoor = totalMeal * POOR;
            string outTipPoor = $"{tipPoor:c}";
            poorServiceBox.Text = outTipPoor;
            // take amount of meal and devide by good service
            double tipGood = totalMeal * GOOD;
            string outTipGood = $"{tipGood:c}";
            goodServiceBox.Text = outTipGood;
            // take amount of meal and devide by excellent service
            double tipExcellent = totalMeal * EXCELLENT;
            string outTipExcellent = $"{tipExcellent:c}";
            excellentServiceBox.Text = outTipExcellent;
        }
    }
}
