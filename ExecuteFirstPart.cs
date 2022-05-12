using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechAssignment
{
    public class ExecuteFirstPart
    {
        public static void Execute()
        {
            Console.WriteLine("Enter the hours");
            int hours = GetHoursInput();

            Console.WriteLine("Enter the minutes");
            int minutes = GetMinutesInput();

            CalculateAngle calculate = new CalculateAngle();
            int temp = calculate.Calculate(hours, minutes);
            if(temp < 0)
                temp *= -1;
            Console.WriteLine("\nThe smaller angle between two arrows is : " + temp);
            Console.WriteLine();
        }
        static int GetHoursInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
                ShowHoursErrorMessage();

            if (input < 0 || input > 24)
            {
                ShowHoursErrorMessage();
                GetHoursInput();
            }
            return input;
        }
        static int GetMinutesInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
                ShowMinutesErrorMessage();

            if(input < 0 || input > 60)
            {
                ShowMinutesErrorMessage();
                GetMinutesInput();
            }
            return input;
        }

        static void ShowHoursErrorMessage()
        {
            Console.WriteLine("Hours must be written in numbers and cannot be lower than 0 and/or higher than 24. Try again");
            Console.WriteLine();
        }
        static void ShowMinutesErrorMessage()
        {
            Console.WriteLine("Minutes must be written in numbers and cannot be lower than 0 and/or higher than 60. Try again");
            Console.WriteLine();
        }
    }
}
