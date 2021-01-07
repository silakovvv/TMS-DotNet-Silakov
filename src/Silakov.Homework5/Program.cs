using Silakov.Homework5.Interfaces;
using Silakov.Homework5.Managers;
using Silakov.Homework5.Models;
using System;

namespace Silakov.Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiger = new Tiger()
            {
                Name = "Diego",
                Age = 7
            };

            var elephant = new Elephant()
            {
                Name = "Manny",
                Age = 9
            };

            var sloth = new Sloth()
            {
                Name = "Sid",
                Age = 12
            };

            tiger.OutputInformation();
            tiger.Growl();

            elephant.OutputInformation();
            elephant.Swim();

            sloth.OutputInformation();
            sloth.Sleep();

            IZooManager zooManager = new ZooManager();
            zooManager.Animals.Add(tiger);
            zooManager.Animals.Add(elephant);
            zooManager.Animals.Add(sloth);

            zooManager.WalkingAroundZoo();
        }
    }
}
