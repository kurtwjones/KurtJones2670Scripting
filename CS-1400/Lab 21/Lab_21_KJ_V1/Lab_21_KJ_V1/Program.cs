//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 21
//Date: 10/20/16

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
//---------------------------------------------------------------------------

using System;

class Program
{
    // some class level constants
    const int HALVES = 50;
    const int QUARTERS = 25;
    const int DIMES = 10;
    const int NICKELS = 5;
    const int PENNIES = 1;
    // The Main Method
    // Purpose: asks user how much money they have. then tells them what coins they have.
    // Parameters: none
    // Returns: text
    static void Main()
    {
        int money;  // the value we want to count change for

        Console.WriteLine("I will make change for you.");
        Console.Write("Enter in an amount between 1 and 99: ");
        money = int.Parse(Console.ReadLine());
        //print how many coins you have
        Console.WriteLine("For {0} you get:", money);
        Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
        Console.WriteLine("{0} quarters", ComputeChange(ref money, QUARTERS));
        Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
        Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
        Console.WriteLine("{0} pennies", ComputeChange(ref money, PENNIES));
        Console.ReadLine();
    }

    // The ComputeChange Method
    // Purpose: Runs a loop to find what coins you have
    // Parameters: a referance of how much money as an int and an int of coin value
    // Returns: an int that counts how many of each coin you have.
    static int ComputeChange(ref int changeValue, int coinValue)
    {
        int counter = 0;
        //loop to find if you have enough money for that coin
        while (changeValue >= coinValue)
        {  
            changeValue = changeValue - coinValue;
            counter++;
        }
        return counter;
    }
}