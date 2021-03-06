﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool play = true;

            while (play)
            {
                number = CollectInput();
                DisplayResults(number);

                Console.WriteLine("Would you like to continue playing? (y/n)");
                string continuePlaying = Console.ReadLine().ToLower().Trim();
                if (continuePlaying == "no" || continuePlaying == "n")
                {
                    play = false;
                }
            }
        }

        // Method to collect user input
        public static int CollectInput()
        {
            Console.WriteLine("Enter an integer greater than 0:");
            string userInput = Console.ReadLine();
            int number;
            int.TryParse(userInput, out number);

            // user input validation
            if (number == 0)
            {
                Console.WriteLine("Invalid input.");
                return CollectInput();
            } 
            else
            {
                return number;
            }
        }
        
        // Method to square user input
        public static int SquareNumber(int number)
        {
            return Convert.ToInt16(Math.Pow(number, 2));
        }

        // Method to cube user input
        public static int CubeNumber(int number)
        {
            return Convert.ToInt16(Math.Pow(number, 3));
        }

        // Method to display table of squarred and cubed user inputs
        public static void DisplayResults(int input)
        {
            Console.WriteLine("Number   Squared   Cubed");
            Console.WriteLine("=======  =======   ======");
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{i + 1}        {SquareNumber(i + 1)}         {CubeNumber(i + 1)}");
            }
        }
    }
}
