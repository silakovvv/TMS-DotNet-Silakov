using System;

namespace Silakov.Homework4
{
    /// <summary>
    /// Задача.
    /// </summary>
    internal class Task
    {
        /// <summary>
        /// Идентификатор задачи.
        /// </summary>
        private int _id;
        /// <summary>
        /// Название задачи.
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание.
        /// </summary>
        private string _description;
        /// <summary>
        /// Статус задачи.
        /// </summary>
        private StatusTask _status;
        /// <summary>
        /// Дата создания.
        /// </summary>
        private DateTime _creationDate;
        /// <summary>
        /// Дата выполнения.
        /// </summary>
        private DateTime _executionDate;

        /// <summary>
        /// Счётчик.
        /// </summary>
        private static int counter = 1;

        public int Id 
        { 
            get 
            {
                return _id;
            } 
        }

        public Task()
        {
            Console.WriteLine("\nAdd new task.");

            Console.Write("Name: ");
            _name = Console.ReadLine();
            Console.Write("Description: ");
            _description = Console.ReadLine();

            _creationDate = DateTime.Now;
            _id = counter;

            counter += 1;
        }

        /// <summary>
        /// Редактировать задачу.
        /// </summary>
        public void Edit()
        {
            Console.Write("Name: ");
            _name = Console.ReadLine();
            Console.Write("Description: ");
            _description = Console.ReadLine();
        }

        /// <summary>
        /// Вывести информацию о задаче.
        /// </summary>
        public void OutputInformationAboutTask()
        {
            Console.Write("Id - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_id.ToString() + "\n");
            Console.ResetColor();
            Console.WriteLine($"Name - {_name}");
            Console.WriteLine($"Description - {_description}");
            Console.WriteLine($"Status - {_status}");
            Console.WriteLine($"Creation date - {_creationDate}");
            if (_executionDate != DateTime.MinValue)
            {
                Console.WriteLine($"Execution date - {_executionDate}");
            }
            Console.WriteLine("-----------------------");
        }

        /// <summary>
        /// Изменить статус задачи.
        /// </summary>
        public void ChangeStatus()
        {
            Console.WriteLine("List of possible statuses:");
            
            int numStatus = 1;
            foreach (StatusTask status in Enum.GetValues(typeof(StatusTask)))
            {
                Console.WriteLine($"{numStatus}. {status}");
                numStatus += 1;
            }

            int chosenIndexStatus;

            Console.Write("Choose index status: ");
            try
            {
                chosenIndexStatus = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You chose incorrect value of index!");
                return;
            }

            if (chosenIndexStatus < 0 || chosenIndexStatus > numStatus)
            {
                Console.WriteLine("You chose incorrect index!");
                return;
            }

            _status = (StatusTask)Enum.GetValues(typeof(StatusTask)).GetValue(chosenIndexStatus-1);
            
            if (_status == StatusTask.completed)
            {
                _executionDate = DateTime.Now;
            }
        }
    }
}
