using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework5.Models
{
    public abstract class AnimalBase
    {
        /// <summary>
        /// Название животного.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Список характеристик.
        /// </summary>
        public List<string> listCharacteristics { get; set; }

        /// <summary>
        /// Вывод списка характеристик.
        /// </summary>
        private void OutputlistCharacteristics()
        {
            Console.WriteLine("List of characteristics:");
            foreach (var characteristic in listCharacteristics)
            {
                Console.WriteLine(characteristic);
            }
        }

        /// <summary>
        /// Добавление характеристики животного.
        /// </summary>
        public void AddCharacteristic()
        {
            Console.Write("Input new characteristic: ");
            string newCharacteristic = Console.ReadLine();

            listCharacteristics.Add(newCharacteristic);
        }

        /// <summary>
        /// Вывод полной информации о животном.
        /// </summary>
        public void OutputInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");

            OutputlistCharacteristics();
        }
    }
}
