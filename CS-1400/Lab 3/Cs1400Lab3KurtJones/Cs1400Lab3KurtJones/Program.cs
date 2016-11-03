//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 3
//Date: 08/30/16

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

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // declare variables
            string name = "";
            int age = 0;
            float money = 0;
            int almostAge = 0;
            // Display "hello, my name is Hal"
            Console.WriteLine("Hello, my name is Hal");
            // Ask for name
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            // Get input and save as 1st variable
            // display "hello {0}, how old are you?
            Console.WriteLine("Hello {0}, how old are you?",name);
            age = int.Parse(Console.ReadLine());
            // Get input and save as 2nd variable 
            // add one to age to soon to be age
            almostAge = age + 1;
            // Display "How much money do you have?
            Console.WriteLine("How much money do you have?");
            money = float.Parse(Console.ReadLine());
            // get input and save as 3rd variable
            // display "thank you {0} you are almost {1} and you have {2}
            Console.WriteLine("Thank you {0}. You are almost {1} and you have {2:c}", name, almostAge, money);
            Console.ReadLine();
        }
    }
}
// question 1: I chose an int because the age is a whole number
// question 2: The advantage of using the {money:c} is it adds a dollar sign
