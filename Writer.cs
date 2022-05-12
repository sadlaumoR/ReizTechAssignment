using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechAssignment
{
    static class Writer
    {
        //Menu choices
        public static void Greet()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Calculate the angles between hour and minute arrows");
            Console.WriteLine("2 - Create and calculate the depth of structure");
        }
        //Validating the input
        public static int GetInput()
        {
            int input;
            while(!int.TryParse(Console.ReadLine(), out input))
            {
                ShowErrorMessage();
            }
            return input;
        }
        public static void ShowErrorMessage()
        {
            Console.WriteLine("Invalid input. Try again");
            Console.WriteLine();
        }
    }
}
