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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        //the CalcHypotenuse Method
        //Purpose: Calculates the hypotenuse
        //Paramaters: none
        //Returns: sideC as a double
        public double CalcHypotenuse ()
        {
            double sideC = Math.Sqrt(Math.Pow(sideA,2) + Math.Pow(sideB,2));
            return sideC;
        }
        //the GetSideA Method
        //Purpose: sets information about sideA
        //Paramaters: sideA as a double
        //Returns: none
        public void GetSideA(double sideA)
        {
            this.sideA = sideA;
        }
        //the GetSideB Method
        //Purpose: sets information about sideB
        //Paramaters: sideB as a double
        //Returns: none
        public void GetSideB(double sideB)
        {
            this.sideB = sideB;
        }
    }
}
