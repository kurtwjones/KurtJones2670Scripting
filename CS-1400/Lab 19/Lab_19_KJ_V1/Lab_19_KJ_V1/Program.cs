//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 19
//Date: 10/20/16

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

namespace Lab_19_KJ_V1
{
    
    class Program
    {
        public RandomNumber Rn;
        // The Main Method
        // Purpose: askes the user if they want to play a dice game
        // Parameters: none
        // Returns: none

        static void Main(string[] args)
        {
            
            const string YES = "y";
            const string NO = "n";
            string response = "";
            RandomNumber Rn = new RandomNumber();
            //Ask the user if they want to play
            do
            {
                Console.WriteLine("Hello. Would you like to play a Dice Game (y/n)? ");
                response = Console.ReadLine();
                //keep user from putting in unexpected value
                if (response != YES && response != NO)
                {
                    Console.Clear();
                    Console.WriteLine("That is not a valid response. Please try again.");
                    
                }
               
            } while (response != YES && response != NO);

            //Get users response. If 'y' call random number program
            if (response == YES)
            {
                Console.Clear();
                Rn.NumGenerator();
            }
            //if 'n' print goodbye message and quit.
            else

            {
                Console.Clear();
                Console.WriteLine("Thanks for playing. Goodbye");
                Console.Read();
            }

        }
    }
}
