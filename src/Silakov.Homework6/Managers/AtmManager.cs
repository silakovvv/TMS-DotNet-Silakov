using Silakov.Homework6.Interfaces;
using Silakov.Homework6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework6.Managers
{
    class AtmManager : Atm, IAtmManager
    {
        public AtmManager(decimal money) : base(money)
        {

        }

        public void TopUpAnAccount()
        {
            Console.Write("Enter sum to add: ");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            PutMoney(money);
        }

        public void WithdrawalOfFunds()
        {
            Console.Write("Enter sum to withdraw: ");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            GetMoney(money);
        }

        public void DisplayActualBalance()
        {
            ShowBalance();
        }

        public void ShowMenu()
        {
            bool needToClose;

            while (true)
            {
                string action = InputAction();

                switch (action)
                {
                    case "A":
                        TopUpAnAccount();
                        continue;
                    case "W":
                        WithdrawalOfFunds();
                        continue;
                    case "D":
                        DisplayActualBalance();
                        continue;
                    case "Q":
                        needToClose = true;
                        break;
                    default:
                        Console.WriteLine("You entered an incorrect value!\n");
                        continue;
                }

                if (needToClose) { break; }
            }
        }

        private static string InputAction()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n***********************");
            Console.WriteLine("Choose operation:");
            Console.WriteLine("Top up an account - [A]");
            Console.WriteLine("Withdrawal of funds - [W]");
            Console.WriteLine("Display actual balance - [D]");
            Console.WriteLine("Quit - [Q]");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Your choice: ");
            Console.ResetColor();
            var action = Console.ReadLine();

            return action;
        }
    }
}
