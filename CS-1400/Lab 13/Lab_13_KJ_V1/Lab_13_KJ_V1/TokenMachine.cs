//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 13
//Date: 09/26/16

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

namespace Lab_13_KJ_V1
{
    

    class TokenMachine
    {
        const int STARTTOKEN = 100;
        const int STARTQUARTER = 0;
        public int numTokens = 100;
        public int numQuarters = 0;
        // The Reset Method
        // Purpose: Resets all the numbers back to the original
        // Parameters: None
        // Returns: none
        public void Reset()
        {
            numTokens = STARTTOKEN;
            numQuarters = STARTQUARTER;
                       
        }
        // The countToken Method
        // Purpose: Returns the amount of tokens
        // Parameters: None
        // Returns: amount of tokens as an int
        public int countToken()
        {
            
           return numTokens;
                 
        }
        // The AboutToolStrip Method
        // Purpose: returns amount of quarters
        // Parameters: None
        // Returns: the amount of quarters as an int
        public int countQuarter()
        {
            return numQuarters;
        }
        // The AboutToolStrip Method
        // Purpose: Grabs the quarter and does the math
        // Parameters: None
        // Returns: None
        public void getQuarter()
        {
            numTokens--;
            numQuarters++;
        }
    }
}
