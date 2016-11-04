//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Project 2
//Date: 09/13/16

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

namespace Project_02_KJ_V1
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
        // on click close window
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // on click show information about creator 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones \n Project 2 \n Cs1400_01 ");
        }
        // The SplitgoldBtn_Click Method
        // Purpose: Takes information from user and devides the gold among the pirates
        // Parameters: two numbers as ints
        // Returns: How many gold pieces each pirate gets
        private void splitGoldBtn_Click(object sender, EventArgs e)
        {
            //declare variables
            int crewCount = 0;
            int totalCrew = 2;
            int goldCount = 0;
            const int PARTYCUT = 3;
            const double JACKCUT = .12;
            const double MATECUT = .08;
            //get amount of crew
            crewCount = int.Parse(numberPirates.Text);
            //amount of crew plus jack and mate
            totalCrew = totalCrew + crewCount;
            //get amount of gold
            goldCount = int.Parse(numberGold.Text);
            //give 3 gold to each crew member
            int remainingGold = goldCount - (crewCount * PARTYCUT);
            //calculate remaining
            //take 12% of gold and give to jack
            int jackTotal = (int)(remainingGold * JACKCUT);
            //calculate remaining
            int newRemainingGold = (int)(remainingGold - jackTotal);
            //take 8% of gold and give to mate
            int mateTotal = (int)(newRemainingGold * MATECUT);
            //calculate remaining
            newRemainingGold = (int)(newRemainingGold - mateTotal);
            //Split between jack, mate, and crew
            double fairShare = newRemainingGold / totalCrew;
             int fairShareJackTotal = (int)(jackTotal + fairShare);
             int fairShareMateTotal = (int)(mateTotal + fairShare);
            int fairShareTotal = (int)fairShare * totalCrew;
            //give remainder to pirate benevolent association
            int remainder = goldCount - (fairShareMateTotal + fairShareJackTotal + fairShareTotal);
            //output totals to text boxes
            string outJackShare = $"{fairShareJackTotal}";
            jackShareBox.Text = outJackShare;
            string outMateShare = $"{fairShareMateTotal}";
            mateShareBox.Text = outMateShare;
            string outCrewCut = $"{fairShare}";
            crewShareBox.Text = outCrewCut;
            string outPBA = $"{remainder}";
            PBFundBox.Text = outPBA;

        }
    }
}
