//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Project 5
//Date: 10/04/16

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

namespace Project_5_KJ_V1
{
    public partial class Form1 : Form
    {
        private SalesInvoice si;
        public Form1()
        {
            InitializeComponent();
            si = new SalesInvoice();
            
        }
        //the aboutToolSstripMenu Method
        //Purpose: shows the information about the programmer
        //Paramaters: numItems as int
        //Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurt Jones\n Project 5\n CS1400_01");
        }
        //the ExitToolstripmenuItem Method
        //Purpose: terminates the program
        //Paramaters: none
        //Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //the NumItems Method
        //Purpose: clear all text boxes
        //Paramaters: none
        //Returns: none
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UnitPriceTxtBx.Clear();
            NumItemsTxtBx.Clear();
        }
        //the BuyBtn Method
        //Purpose: grabs information from the textboxes, calls the salesinvoce class and prints out information
        //Paramaters: object
        //Returns: message box
        private void BuyBtn_Click(object sender, EventArgs e)
        {
            int numItems = int.Parse(NumItemsTxtBx.Text);
            double unitPrice = double.Parse(UnitPriceTxtBx.Text);
            si.NumItems(numItems);
            si.price(unitPrice);
            double netPrice = si.NetPrice();
            double withSales= si.CalcSalesTax(netPrice);
            double withLocal = si.CalcLocalTax(netPrice);
            double total = si.Total(netPrice, withSales, withLocal);
            string s1 = String.Format("Quantity: {0}\n", numItems);
            string s2 = String.Format("Unit Price: {0:f2}\n",unitPrice);
            string s3 = String.Format("------------------------\n");
            string s4 = String.Format("Net Price: {0:f2}\n", netPrice);
            string s5 = String.Format("State Tax: {0:f2}\n", withSales);
            string s6 = String.Format("Local Sales Tax: {0:f2}\n", withLocal);
            string s7 = String.Format("Total amount due: {0:f2}\n", total);
            MessageBox.Show(s1 + s2 + s3 + s4 + s5 + s6 + s7);
        }
    }
}
