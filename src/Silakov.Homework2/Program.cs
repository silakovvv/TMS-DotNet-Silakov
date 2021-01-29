using System;

namespace Silakov.Homework2
{
    internal class Program
    {
        private enum DaysOfWeek
        {
            monday = 1,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,
        }

        private static void Main(string[] args)
        {
            string day = InputDay();

            if (!DayIsCorrect(day))
            {
                Console.WriteLine("Invalid value entered for the day of the week..");
                Console.ReadKey();
                return;
            }

            string currentDayOfWeek = GetCurrentDayOfWeek();

            if (day == currentDayOfWeek)
            {
                Console.WriteLine($"You're right, today is {day}");
            }
            else
            {
                Console.WriteLine($"You entered the correct date but today is {currentDayOfWeek}");
            }

            Console.ReadKey();
            return;
        }

        private static string InputDay()
        {
            Console.Write("Input a day of the week: ");
            var userInput = Console.ReadLine();
            return userInput;
        }

        private static bool DayIsCorrect(string day)
        {
            return Enum.IsDefined(typeof(DaysOfWeek), day.ToLower());
        }

        private static string GetCurrentDayOfWeek()
        {
            return DateTime.Now.DayOfWeek.ToString().ToLower();
        }

    }
}
