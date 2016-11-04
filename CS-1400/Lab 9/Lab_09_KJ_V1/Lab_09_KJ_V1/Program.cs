//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 9
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

namespace Lab_09_KJ_V1
{
    class Program
    {
        static void Main()
        {
            int radius = 0;
            int radiusDoubled = 2;
            
            //ask user for the radius of the circle
            Console.Write("What is the radius of the circle watering system? ");
            radius = int.Parse(Console.ReadLine());
            //Take radius and times by 2 to get side of square
            int sideOfSquare = radius * radiusDoubled;
            //Take side of square and times by 2 to get area of square
            double areaOfSquare = Math.Pow(sideOfSquare,2);
            //calculate area of circle with PI R Squared
            double areaOfCircle = Math.PI *(Math.Pow(radius,2));
            //subtract area of square from area of circle
            double shadedArea = areaOfSquare - areaOfCircle;
            //output shaded area
            Console.Write("Wow the area that isnt being watered is: {0:F2}", shadedArea);
            Console.Read();
        }
    }
}

