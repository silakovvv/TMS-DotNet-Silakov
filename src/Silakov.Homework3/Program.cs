using System;

namespace Silakov.Homework3
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
            OpenMenu();
        }

        private static void OpenMenu()
        {
            bool needToClose;

            while (true)
            {
                int action = InputAction();

                switch (action)
                {
                    case 1:
                        DayHandler();
                        continue;
                    case 2:
                        Console.Clear();
                        continue;
                    case 3:
                        needToClose = true;
                        break;
                    default:
                        Console.WriteLine("You entered an incorrect value!\n");
                        continue;
                }

                if (needToClose) { break; }
            }
        }

        private static int InputAction()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1. Date handler.");
            Console.WriteLine("2. Сlear the console.");
            Console.WriteLine("3. Quit.");

            Console.Write("Your choice: ");
            var action = Console.ReadLine();

            try
            {
                return Convert.ToInt32(action);
            }
            catch
            {
                return -1;
            }
        }

        private static void DayHandler()
        {
            string day = InputDay();

            if (!DayIsCorrect(day))
            {
                Console.WriteLine("Invalid value entered for the day of the week..\n");
                return;
            }

            string currentDayOfWeek = GetCurrentDayOfWeek();

            if (day == currentDayOfWeek)
            {
                Console.WriteLine($"You're right, today is {day}\n");
            }
            else
            {
                Console.WriteLine($"You entered the correct date but today is {currentDayOfWeek}\n");
            }
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
