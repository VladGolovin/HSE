namespace TaskRunner
{
    using System;
    using System.Collections.Generic;
    using Helpers;

    /// <summary>
    /// Класс для запуска лабораторных задач.
    /// </summary>
    public class TaskRunner
    {
        /// <summary>
        /// Список запускаемых задач
        /// </summary>
        private List<Action> tasks;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="tasks">Список запускаемых задач.</param>
        public TaskRunner(List<Action> tasks)
        {
            this.tasks = tasks;
        }

        /// <summary>
        /// Отображает в консоль меню приложения и запускает выбранные пользователем задачи.
        /// </summary>
        public void Start()
        {
            int menuItem = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберете задачу:");

                for (int i = 1; i <= tasks.Count; i++)
                {
                    Console.WriteLine($"{i} - Задача {i}");
                }
                Console.WriteLine($"{tasks.Count + 1} - Выход.");

                IOHelper.ReadValueSafely(ref menuItem, "пункт меню");

                if (menuItem >= 1 && menuItem < tasks.Count + 1)
                {
                    int subMenuItem = 2;

                    do
                    {
                        Console.WriteLine();

                        tasks[menuItem - 1].Invoke();

                        Console.WriteLine();

                        Console.WriteLine("1 - Повторить.");
                        Console.WriteLine("2 - Вернутся в основное меню.");

                        do
                        {
                            IOHelper.ReadValueSafely(ref subMenuItem, "пункт меню");
                        } while (!(subMenuItem == 1 || subMenuItem == 2));

                    } while (subMenuItem != 2);
                }

            }
            while (menuItem != tasks.Count + 1);
        }
    }
}
