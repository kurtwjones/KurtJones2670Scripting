//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 15
//Date: 10/06/16

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

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        private Triangle Tri;
        public Form1()
        {
            InitializeComponent();
            Tri = new Triangle();
        }
        //the aboutToolStripMenu Method
        //Purpose: show information about creator
        //Paramaters: none
        //Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n CS1400_01\n Lab 15");
        }
        //the ExitToolStripMenu Method
        //Purpose: terminate program
        //Paramaters: none
        //Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //the aboutToolStripMenu Method
        //Purpose: clear all text boxes
        //Paramaters: none
        //Returns: none
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            sideATxtBx.Clear();
            sideBTxtBx.Clear();
            sideCTxtBx.Clear();
        }
        //the CalculateBtn Method
        //Purpose: collects information then passes it to triangle class
        //Paramaters: none
        //Returns: message box
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(sideATxtBx.Text);
            double sideB = double.Parse(sideBTxtBx.Text);
            Tri.GetSideA(sideA);
            Tri.GetSideB(sideB);
            double sideC = Tri.CalcHypotenuse();
            string sideCText = $"{sideC:f2}";
            sideCTxtBx.Text = sideCText;
        }
    }
}
