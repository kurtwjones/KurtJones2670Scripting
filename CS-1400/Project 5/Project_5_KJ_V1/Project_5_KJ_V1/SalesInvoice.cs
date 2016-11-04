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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5_KJ_V1
{
    class SalesInvoice
    {
        private const double SALESTAX = .0745;
        private const double LOCALTAX = .025;
        private int numItems;
        private double Price;
        //the NetPrice Method
        //Purpose: Calculates the NetPrice using number of items and price
        //Paramaters: none
        //Returns: double netprice.
        public double NetPrice()
        {
           double netprice = numItems * Price;
            return netprice;
        }
        //CalcSalesTax Method
        //Purpose: Calculates the sales tax
        //Paramaters: netprice as a double
        //Returns: sales tax as a double
        public double CalcSalesTax (double netprice)
        {
            double withSales = SALESTAX * netprice;
            return withSales;
            
        }
        //the CalcLocalTax Method
        //Purpose: Calculates local tax
        //Paramaters: netprice as a double
        //Returns: local tax
        public double CalcLocalTax(double netprice)
        {
            double withLocal = LOCALTAX * netprice;
            return withLocal;
        }
        //the Total Method
        //Purpose: Calculates the total amount due
        //Paramaters: netprice, withsales and withlocal as doubles
        //Returns: total as a double
        public double Total(double netprice, double withSales, double withLocal)
        {
            double total = withSales + withLocal + netprice;
            return total;
        }
        //the NumItems Method
        //Purpose: sets the number of items
        //Paramaters: numItems as int
        //Returns: none
        public void NumItems(int numItems)
        {
            this.numItems = numItems;
        }
        //the price Method
        //Purpose: sets the price of the items
        //Paramaters: numItems as int
        //Returns: none
        public void price(double price)
        {
            this.Price= price;
        }
    }
}
