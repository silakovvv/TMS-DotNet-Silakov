using System;
using System.Collections.Generic;

namespace Silakov.Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Fitness Tracker...");
            IEnumerable<Training> trainings = TrainingGenerator.GetTrainings();
            Console.WriteLine("Started Fitness Tracker.");

            var averageDistance = TrainingGenerator.GetAverageDistance(trainings);
            var allTimeDistance = TrainingGenerator.GetAllTimeDistance(trainings);
            var maxDistance = TrainingGenerator.GetMaxDistance(trainings);

            Console.WriteLine($"Avarage distance for all trainings: {averageDistance}");
            Console.WriteLine($"Max distance for all trainings: {maxDistance}");
            Console.WriteLine($"Distance for all trainings: {allTimeDistance}");
        }
    }
}
