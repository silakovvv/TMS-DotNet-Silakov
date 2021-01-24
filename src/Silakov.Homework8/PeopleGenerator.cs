using System;
using System.Threading;

namespace Silakov.Homework8
{
    public class PeopleGenerator
    {
        private static ThreadLocal<Random> _random;
        private static string[] _predefinedNames;

        public PeopleGenerator()
        {
            var seed = Environment.TickCount;
            _random = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));
            
            _predefinedNames = new string[]
            {
                "Emma","Noah","Mia",
                "William","Jacob","Liam",
                "Alice","Asher","Michael"
            };
        }

        public Person GetPerson()
        {
            int index = _random.Value.Next(0, _predefinedNames.Length);

            return new Person
            {
                TimeToProcess = _random.Value.Next(5000),
                Name = _predefinedNames[index],
            };
        }
    }
}