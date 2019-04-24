using System;
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
            int input = CollectInput();
            Console.WriteLine();
            Console.WriteLine("Number   Squared   Cubed");
            Console.WriteLine("=======  =======   ======");
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{i + 1}        {SquareNumber(i + 1)}         {CubeNumber(i + 1)}");
            }


        }
        public static int CollectInput()
        {
            Console.WriteLine("Enter an integer greater than 0:");
            string userInput = Console.ReadLine();
            int number;
            int.TryParse(userInput, out number);

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

        public static int SquareNumber(int number)
        {
            return Convert.ToInt16(Math.Pow(number, 2));
        }

        public static int CubeNumber(int number)
        {
            return Convert.ToInt16(Math.Pow(number, 3));
        }
    }
}
