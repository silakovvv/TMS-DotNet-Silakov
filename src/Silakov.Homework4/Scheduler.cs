﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Silakov.Homework4
{
    public class Scheduler : IMenu
    {
        /// <summary>
        /// Список задач.
        /// </summary>
        private List<Task> listTask;

        public Scheduler()
        {
            listTask = new List<Task>();
        }

        /// <summary>
        /// Добавить задачу.
        /// </summary>
        public void AddTask()
        {
            listTask.Add(new Task());
        }

        /// <summary>
        /// Получить идентификатор задачи, введённый пользователем.
        /// </summary>
        /// <returns>Идентификатор задачи</returns>
        private int GetIdTask()
        {
            int idTask;

            Console.Write("\nInput id task: ");
            try
            {
                idTask = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You input incorrect value of id!");
                return 0;
            }

            return idTask;
        }

        /// <summary>
        /// Изменить задачу.
        /// </summary>        
        public void EditTask()
        {
            var idTask = GetIdTask();
            if (idTask == 0)
            {
                return;
            }

            var tasks = listTask.Where(x => x.Id == idTask).ToList();

            foreach (var task in tasks)
            {
                Console.WriteLine("\nChose the editing mode:");
                Console.WriteLine("1. Edit task;");
                Console.WriteLine("2. Change status task.");

                Console.Write("Your choice: ");
                int editingMode = Convert.ToInt32(Console.ReadLine());

                switch (editingMode)
                {
                    case 1:
                        task.Edit();
                        break;
                    case 2:
                        task.ChangeStatus();
                        break;
                }

                break;
            }
        }

        /// <summary>
        /// Удалить задачу.
        /// </summary>
        public void DeleteTask()
        {
            var idTask = GetIdTask();
            if (idTask == 0)
            {
                return;
            }

            var tasks = listTask.Where(x => x.Id == idTask).ToList();

            foreach (var task in tasks)
            {
                listTask.Remove(task);
                break;
            }
        }

        /// <summary>
        /// Вывести список задач.
        /// </summary>
        public void OutputAllTasks()
        {
            Console.WriteLine("\n-----Our scheduler-----");
            foreach (var task in listTask)
            {
                task.OutputInformationAboutTask();
            }
        }

        public void Menu()
        {
            bool needToClose;

            while (true)
            {
                string action = InputAction();

                switch (action)
                {
                    case "A":
                        AddTask();
                        continue;
                    case "E":
                        EditTask();
                        continue;
                    case "D":
                        DeleteTask();
                        continue;
                    case "S":
                        OutputAllTasks();
                        continue;
                    case "Q":
                        needToClose = true;
                        break;
                    default:
                        Console.WriteLine("You entered an incorrect value!\n");
                        continue;
                }

                if (needToClose) { break; }
            }
        }

        private static string InputAction()
        {
            Console.WriteLine("\n***********************");
            Console.WriteLine("Select an action:");
            Console.WriteLine("Add task - A");
            Console.WriteLine("Edit task - E");
            Console.WriteLine("Delete task - D");
            Console.WriteLine("Show tasks - S");
            Console.WriteLine("Quit - Q");

            Console.Write("Your choice: ");
            var action = Console.ReadLine();

            return action;
        }
    }
}
