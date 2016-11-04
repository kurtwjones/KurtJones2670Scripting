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
    class RandomNumber
    {
        private const int boxCar = 6;
        private const int snakeEye = 1;
        private int firstNumber = 0;
        private int secondNumber = 0;
        private const string YES = "y";
        private const string NO = "n";
        private string response = "";
       
        // The NumGenerator Method
        // Purpose: Generates two random numbers
        // Parameters: none
        // Returns: none

        public void NumGenerator()
        {
            //Generate two random numbers between 1-6
            Random dieValue = new Random();
            firstNumber = dieValue.Next(1, 7);
            secondNumber = dieValue.Next(1, 7);
            //run diceresults method
            DiceResults();

        }
        // The DiceResults Method
        // Purpose: Prints the dice results to console
        // Parameters: none
        // Returns: none

        public void DiceResults()
        {
            //if the two numbers are 6 and 6 display "You got Boxcars"
            if (firstNumber == boxCar && secondNumber == boxCar)
                Console.WriteLine("You got Boxcars");
            //if the two numbers are 1 and 1 display "You rolled snake-eyes"
            else if (firstNumber == snakeEye && secondNumber == snakeEye)
                Console.WriteLine("You rolled snake-eyes.");
            //if something else display "you rolled" and the two numbers
            else
                Console.WriteLine("You rolled {0} and {1}", firstNumber, secondNumber);
            //run playagain method
            PlayAgain();
        }
        // The PlayAgain Method
        // Purpose: Askes the user if they want to play again
        // Parameters: none
        // Returns: none

        public void PlayAgain()
        {
            //Ask the user if they want to play again
            do
            {
                Console.WriteLine("Would you like to play again? (y/n) ");
                response = Console.ReadLine();
                Console.Clear();
                //Keep the user from putting in unexpected values
                if (response != YES && response != NO)
                {
                    Console.WriteLine("That is not a valid response. Please try again.");
                }

            } while (response != YES && response != NO);

            //Get users response. If 'y' call random number program
            if (response == YES)
            {
                NumGenerator();
            }
            //if 'n' print goodbye message and quit.
            else

            {
                Console.WriteLine("Thanks for playing. Goodbye");
                Console.Read();
            }
        }
    }
}

