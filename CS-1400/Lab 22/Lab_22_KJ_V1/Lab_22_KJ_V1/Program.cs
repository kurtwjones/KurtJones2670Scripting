//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 22
//Date: 11/01/16

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

namespace Lab_22_KJ_V1
{
    class Program
    {
        // The main Method
        // Purpose: Asks user for scores and places them in an array, calls sum method then prints results
        // Parameters:none
        // Returns:none

        static void Main()
        {
            //initialize variables
            const int SIZE = 10;
            
            int[] numbers = new int[SIZE];
            //ask user for the numbers
            //loop to get each number in array
            Console.WriteLine("This program will add all of your scores together.");
            for (int i = 0; i <= SIZE -1; i++)
            {
                Console.WriteLine("Please enter the score for number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //run sum method and save return value
           int sum = Sum(numbers);
            //print results
            Console.WriteLine("The total of your scores is: {0} ", sum);
            Console.ReadLine();
        }

        // The Sum Method
        // Purpose: adds all of the items in the array together
        // Parameters: An array of all of the scores
        // Returns: An int as total

        public static int Sum(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i <= numbers.Length -1; i++)
            {
                total += numbers[i];
            }
            return total;
        }
    }
}
