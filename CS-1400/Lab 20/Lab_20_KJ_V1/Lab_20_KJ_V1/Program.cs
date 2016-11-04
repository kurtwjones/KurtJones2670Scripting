//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 20
//Date: 10/20/16

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
//---------------------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // declare some variables to test the program
        int number1 = 10;
        int number2 = 15;

        // call the Swap method and output the result
        Swap(ref number1,ref number2);
        Console.WriteLine("number1 = {0}", number1);
        Console.WriteLine("number2 = {0}", number2);

        Console.ReadLine();
    }

    // The Swap method
    // Purpose: To interchange the value of two variables
    // Parameters: two integers
    // Returns: None
    // Pre-conditions: None
    // Post-conditions: None
    // Side Effect: the values of the 2 integers are swapped

    static void Swap(ref int n1,ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2 = temp;

    }
}