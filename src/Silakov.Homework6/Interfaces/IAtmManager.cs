using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework6.Interfaces
{
    interface IAtmManager
    {
        /// <summary>
        /// Пополнить счёт.
        /// </summary>
        public void TopUpAnAccount();

        /// <summary>
        /// Вывод средств.
        /// </summary>
        public void WithdrawalOfFunds();

        /// <summary>
        /// Отображение фактического баланса
        /// </summary>
        public void DisplayActualBalance();
    }
}
