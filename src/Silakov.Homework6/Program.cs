using Silakov.Homework6.Managers;
using System;

namespace Silakov.Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter current balance: ");
            var currentBalance = Convert.ToDecimal(Console.ReadLine());

            AtmManager atmManager = new AtmManager(currentBalance);
            atmManager.Notify += DisplayMessage;

            atmManager.ShowMenu();
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
