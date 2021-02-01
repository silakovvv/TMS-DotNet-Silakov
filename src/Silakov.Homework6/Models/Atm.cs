using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework6.Models
{
    public class Atm
    {
        /// <summary>
        /// Баланс.
        /// </summary>
        private decimal _balance;

        public delegate void BalanceHandler(string message);
        public event BalanceHandler Notify;

        public Atm(decimal currentBalance)
        {
            _balance = currentBalance;
        }

        /// <summary>
        /// Положить деньги.
        /// </summary>
        /// <param name="money">Сумма вклада</param>
        public void PutMoney(decimal sum)
        {
            _balance += sum;
            Notify?.Invoke($"The account received: {sum}");
        }

        /// <summary>
        /// Снять деньги.
        /// </summary>
        /// <param name="money">Сумма снятия</param>
        public void GetMoney(decimal sum)
        {
            if (sum <= _balance)
            {
                _balance -= sum;
                Console.ForegroundColor = ConsoleColor.Green;
                Notify?.Invoke($"Withdrawn from the account: {sum}");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Notify?.Invoke($"Not enough money in the account! Your actual balance: {_balance}");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        /// <summary>
        /// Вывести на экран текущий баланс.
        /// </summary>
        public void ShowBalance()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your actual balance: {_balance}");
            Console.ResetColor();
        }
    }
}
