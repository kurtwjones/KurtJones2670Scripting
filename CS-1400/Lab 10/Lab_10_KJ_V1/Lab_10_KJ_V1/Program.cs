//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 10
//Date: 09/17/16

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

namespace Lab_10_KJ_V1
{
    class Program
    {
        static void Main()
        {
            // Get the length of side 1 of the triangle
            Console.WriteLine("What is the length of the first side of your triangle? ");
            // save input as side1
            double side1 = double.Parse(Console.ReadLine());
            // get the length of side 2 of the triangle
            Console.WriteLine("What is the length of the second side of your triangle? ");
            // save input as side2
            double side2 = double.Parse(Console.ReadLine());
            // call CalcHypotenuse method
            double total = CalcHypotenuse(side1, side2);
            // save value returned by method
            // display returned value
            Console.WriteLine("The Hypotenuse of your triangle is: {0:F2}", total);
            Console.Read();
        } //end main()
        static double CalcHypotenuse (double side1, double side2)
        {
            // take side1 and Square it
            double side1SQ = Math.Pow(side1,2);
            // save to side1SQ
            // take side 2 and square it
            double side2SQ = Math.Pow(side2,2);
            // save to side1SQ
            // add together side1sq and side2sq
            double answerSQ = side1SQ + side2SQ;
            // save to answer
            // square root answer
            double total = Math.Sqrt(answerSQ);
            // return value 
            return total;
        }
    }
}
// Question 1: Methods are usefull because you can call 
//             a complex code statement multiple times without writing the code over and over
// Question 2: Passing parameters to a method is usefull because you dont have to create new ones
