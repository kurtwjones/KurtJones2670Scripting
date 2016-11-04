//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Project 4
//Date: 09/25/16

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

namespace Project_4_KJ_V1
{
    public partial class Form1 : Form
    {
        public const int TWO = 2;
        public const int RADIAN = 180;
        public Form1()
        {
            InitializeComponent();
        }
        // The AboutToolStrip Method
        // Purpose: Displays information about the creator
        // Parameters: None
        // Returns: Text
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n Project 4\n CS1400_01");
        }
        // The ExitToolStrip Method
        // Purpose: Closes the aplication
        // Parameters: None
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // the ClearButton Method
        //purpose: Clear all text boxes
        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            sideATxtBx.Clear();
            sideBTxtBx.Clear();
            sideCTxtBx.Clear();
            angleCTxtBx.Clear();
            angleATxtBx.Clear();
            AngleBTxtBx.Clear();
        }
        //the Calc_Btn_Click Method
        //Purpose: Calculates the Side of a triangle
        //Paramaters: 3 sides and 3 angles as doubles
        //Returns: 6 text boxes as strings
        private void Calc_Btn_Click(object sender, EventArgs e)
        {

            //Get Input from user for side a
            int sideA = int.Parse(sideATxtBx.Text);
            //Get Input from user for side b
            int sideB = int.Parse(sideBTxtBx.Text);
            //Get Input from user for Angle C
            int angleC = int.Parse(angleCTxtBx.Text);
            //use law of cosign to find side c. Call cosign method
            double SideC = lawOfCosign(sideA, sideB, angleC);
            double angleA = lawOfCosignForA(sideA, sideB, SideC);
            double angleB = lawOfCosignForB(sideA, sideB, SideC);
            //Format and output
            string sideCOutText = $"{SideC:f2}";
            sideCTxtBx.Text = sideCOutText;
            string angleAOutText = $"{angleA:f2}";
            angleATxtBx.Text = angleAOutText;
            string angleBOutText = $"{angleB:f2}";
            AngleBTxtBx.Text = angleBOutText;

        }
        //the lawOfCosign Method
        //Purpose: takes information and calculates cosign
        //Paramaters: sideA SideB and AngleC as ints
        //Returns: sideC as double
        private double lawOfCosign (int sideA, int sideB, int AngleC)
        {
            double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - (TWO * (sideA) * (sideB) * Math.Cos(AngleC * (Math.PI / RADIAN))));
            return sideC;
        }
        //the lawOfCosignForA Method
        //Purpose: takes information and calculates cosign
        //Paramaters: sideA SideB and SideC as ints
        //Returns: AngleA as double
        private double lawOfCosignForA (int sideA, int sideB, double sideC)
        {
            double angleA = Math.Acos((Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / (TWO * (sideB) * (sideC))) * (RADIAN / Math.PI);
            return angleA;
       }
        //the lawOfCosignForB Method
        //Purpose: takes information and calculates cosign
        //Paramaters: sideA SideB and SideC as ints
        //Returns: AngleB as double
        private double lawOfCosignForB(int sideA, int sideB, double sideC)
        {
            double angleB = Math.Acos((Math.Pow(sideC, 2) + Math.Pow(sideA, 2) - Math.Pow(sideB, 2)) / (TWO * (sideA) * (sideC))) * (RADIAN / Math.PI);
           return angleB;
       }
    }
}
