using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using System.IO;
using third_version_try;

namespace third_version_try
{
	/// <summary>
	/// Menu class which redirects to certain method by entering an option by keyboard
	/// </summary>
	public static class Class1
	{
		    public static void Menu()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Welcome to Lab!");
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine("1. Enter grades from keyboard");
                Console.WriteLine("2. Generate grades randomly");
                Console.WriteLine("3. Read from file");
                Console.WriteLine("Type TERMINATE if you want to exit the program");
                choice = Console.ReadLine();
                if (choice == "TERMINATE")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (choice == "1")
                {
                    //call 1st program
                   Ex1.Exercise1();
                }
                else if (choice == "2")
                {
                    //call 2nd program
                    Ex2.Exercise2();
                }
                else if (choice == "3")
                {
                	//call 3rd program
                	Ex3.Exercise3();
                }
            }
        }
	}
}
