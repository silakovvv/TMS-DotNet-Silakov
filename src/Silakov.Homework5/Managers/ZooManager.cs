using Silakov.Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework5.Managers
{
    class ZooManager
    {
        /// <summary>
        /// Список животных зоопарка.
        /// </summary>
        private List<AnimalBase> Animals { get; set; }

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public ZooManager()
        {
            Animals = new List<AnimalBase>();
        }

        /// <summary>
        /// Добавление нового животного.
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(AnimalBase animal)
        {
            Animals.Add(animal);
        }

        /// <summary>
        /// Вывод всех животных.
        /// </summary>
        public void WalkingAroundZoo()
        {
            foreach (var animal in Animals)
            {
                animal.OutputInformation();
            }
        }
    }
}
