//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 16
//Date: 10/01/16

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

namespace Lab_16_KJ_V1
{
    class Program
    {
        static void Main()
        {
            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";
            const double FREEZETEMP = 33;
            // declare a variable to hold user's input
            string today;

            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();
           
            // see if it is a work day
            if (today != SUN && today != SAT)
            {
                Console.WriteLine("What is the temperature outside?");
                double temp = double.Parse(Console.ReadLine());
                if (temp >= FREEZETEMP)
                {
                    // it is a workday, display the go to work message
                    Console.WriteLine("go to work");
                    Console.Read();
                }
                else
                {
                    //Print go to work and dress warmly
                    Console.WriteLine("go to work and dress warmly");
                }
            
            }
            else
            {  
                // its not a workday, display the weekend message
                Console.WriteLine("Ahh... the weekend. No work!");
            }

            Console.ReadLine();
        }//End Main()
    }//End class Program
}
//Question 1: True
//Question 2: True

