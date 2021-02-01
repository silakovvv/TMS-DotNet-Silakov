using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Silakov.Homework7
{
    public class TrainingGenerator
    {
        private static readonly Random _random = new Random(); 

        public static IEnumerable<Training> GetTrainings()
        {
            return Enumerable.Range(0, 100).Select(CreateTraining);
        }

        public static Training CreateTraining(int num)
        {
            return new Training()
            {
                StartDate = DateTime.Now,
                Duration = TimeSpan.FromMinutes(_random.Next(200)),
                Distance = _random.NextDouble() * (10000 - 500) + 500,
                Steps = _random.Next(20000),
                AveragePulse = _random.Next(50, 150),
            };
        }

        public static double GetMaxDistance(IEnumerable<Training> trainings)
        {
            return trainings.Max(training => training.Distance);
        }

        public static double GetAllTimeDistance(IEnumerable<Training> trainings)
        {
            return trainings.Sum(training => training.Distance);
        }

        public static double GetAverageDistance(IEnumerable<Training> trainings)
        {
            return trainings.Average(training => training.Distance);
        }
    }
}
