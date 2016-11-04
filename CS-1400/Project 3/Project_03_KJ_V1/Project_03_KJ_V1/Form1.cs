//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Project 3
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

namespace Project_03_KJ_V1
{
    public partial class Form1 : Form
    {
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
            MessageBox.Show("Kurt Jones\nProject 3\nCS1400_01");
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
        private void ClearButton_Click(object sender, EventArgs e)
        {
            oldStartTimeTxtBox.Clear();
            oldEndTimeTxtBox.Clear();
            newEndTimeTxtBox.Clear();    
        }
        //the CalculateButton Method
        //Purpose: Calculates the new time after construction
        //Paramaters: two ints which contain the old start and end times
        //Returns: an int that contains the new end time
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declare constants
            const int MINUTES = 60;
            const int FULLDAY = 1440;
            const double CONSTRUCTION = .25;
            const int HUNDRED_PART = 100;
            //Get old start time in 24hr format
            int oldStartTime = int.Parse(oldStartTimeTxtBox.Text);
            //Get old end time in 24hm format
            int oldEndTime = int.Parse(oldEndTimeTxtBox.Text);
            //set values and convert to minutes
            int oldStartTimeHours = oldStartTime / HUNDRED_PART;
            int oldStartTimeminutes = oldStartTime % HUNDRED_PART;
            int oldEndTimeHours = oldEndTime / HUNDRED_PART;
            int oldEndTimeminutes = oldEndTime % HUNDRED_PART;
            int minOldStart = MINUTES * oldStartTimeHours + oldStartTimeminutes;
            int minOldEnd = MINUTES * oldEndTimeHours + oldEndTimeminutes;
            //Subtract start time to end time
            int minNewEnd = minOldEnd - minOldStart;
            //some logic to keep it right just in case it rolls over
            if (minOldEnd < minOldStart)
            {
                minNewEnd = minNewEnd + FULLDAY;
            }

            //add 25 percent time for construction
            double constructionDelay = minNewEnd * CONSTRUCTION;
            int newMinEndTime = ((int)constructionDelay) + minOldEnd;
            //logic in case you have a huge drive time
            if (newMinEndTime > FULLDAY)
            {
               newMinEndTime = newMinEndTime - FULLDAY;
            }

            //convert back to HHMM
            int newEndHours = newMinEndTime / MINUTES;
            int newEndMinutes = (int)(MINUTES * (((double)newMinEndTime / MINUTES) - newEndHours));

            //display new end time
            string outNewEndTime = $"{newEndHours:d2}" + $"{newEndMinutes:d2}";
            newEndTimeTxtBox.Text = outNewEndTime;
            
        }
    }
}
