//Project Prolog
//Name: Kurt Jones
//CS 1400 Section 001
//Project: Lab 1
//Date: 08/24/16

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
//---------------------------------------------------------------------------

using System;
using static System.Console;

namespace project1Cs1400 //Begin Namespace
{
static class Program //Begin Class
{
    static void Main() // Begin Main
    {
        // Strings that contain student information
        string name = "Kurt Jones";
        string course = "Cs 1400";
        string section = "Section one";
        string project = "lab one";

        // Code to output strings to console
        WriteLine ("name: {0}",name);
        WriteLine ("course: {0}", course);
        WriteLine("Section: {0}", section);
        WriteLine("Project: {0}", project);

        WriteLine("Press any key to continue");

        ReadKey(true);
     } // End Main
}   //End Class

}
// question one: (C)
// question two: (B)
