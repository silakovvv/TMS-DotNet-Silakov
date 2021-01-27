using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Silakov.Homework8
{
    internal class Shop
    {
        private PeopleGenerator _peopleGenerator;
        private Queue<Person> _processingQueue;
        private List<Thread> _processors;
        private Thread _queueProcessingThread;

        private static Random _random;

        private bool _isOpen;
        private DateTime _storeClosingTime;

        public Shop(PeopleGenerator peopleGenerator, int cashierNumber, int shopOpeningHours)
        {
            _peopleGenerator = peopleGenerator;
            _processingQueue = new Queue<Person>();

            _processors = new List<Thread>();
            for (int i = 0; i < cashierNumber; i++)
            {
                _processors.Add(new Thread(ProcessPeople));
            }

            _random = new Random();

            _queueProcessingThread = new Thread(EnterShop);

            _storeClosingTime = DateTime.Now.AddMinutes(shopOpeningHours);
        }

        public void Open()
        {
            _isOpen = true;
            Console.WriteLine("Shop is open.");

            for(int i = 1; i <= _processors.Count; i++)
            {
                _processors[i-1].Start(i);
                Console.WriteLine($"Cashier {i} is open");
            }

            _queueProcessingThread.Start();
        }

        public void Close()
        {
            _isOpen = false;
        }

        public void EnterShop()
        {
            while (_isOpen)
            {
                lock (_peopleGenerator)
                {
                    try
                    {
                        var newPerson = _peopleGenerator.GetPerson();
                        _processingQueue.Enqueue(newPerson);
                        Console.WriteLine($"A new person has been added to the queue - {newPerson.Name}.");
                    }
                    catch(PersonException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                Thread.Sleep(2000);

                if (DateTime.Now >= _storeClosingTime)
                {
                    _isOpen = false;
                }
            }
        }

        private void ProcessPeople(object obj)
        {
            while(_isOpen || _processingQueue.Count != 0)
            {
                lock (_processingQueue)
                {
                    if (_processingQueue.TryDequeue(out var person))
                    {


                        Console.WriteLine($"Cachier {obj} is processing {person.Name}...");
                        Thread.Sleep(person.TimeToProcess);
                        Console.WriteLine($"Cachier {obj} is processed {person.Name}.");
                    }
                }
            }
            Console.WriteLine($"Cashier {obj} is close.");
        }
    }
}