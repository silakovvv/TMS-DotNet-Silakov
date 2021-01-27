using System;
using System.Threading;

namespace Silakov.Homework8
{
    public class PeopleGenerator
    {
        private static Random _random;
        private static string[] _predefinedNames;

        public PeopleGenerator()
        {
            _random = new Random();
            
            _predefinedNames = new string[]
            {
                "Emma","Noah","Mia",
                "William","Jacob","Liam",
                "Alice","Asher","Michael"
            };
        }

        public Person GetPerson()
        {
            int index = _random.Next(0, _predefinedNames.Length);

            return new Person
            {
                TimeToProcess = _random.Next(5000),
                Name = _predefinedNames[index],
            };
        }
    }
}