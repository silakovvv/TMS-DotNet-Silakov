using System;
using System.Collections.Generic;
using System.Linq;

namespace Silakov.Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var scheduler = new Scheduler();

            scheduler.AddTask();
            scheduler.AddTask();
            scheduler.AddTask();

            scheduler.OutputAllTasks();

            scheduler.EditTask();
            
            scheduler.OutputAllTasks();

            Console.ReadKey();
        }
    }
}
