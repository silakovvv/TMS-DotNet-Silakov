using System;

namespace Silakov.Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleGenerator = new PeopleGenerator();

            Console.Write("Enter store opening hours(in minutes): ");
            int.TryParse(Console.ReadLine(), out int shopOpeningHours);

            var shop = new Shop(peopleGenerator, 3, shopOpeningHours);

            shop.Open();
        }
    }
}
