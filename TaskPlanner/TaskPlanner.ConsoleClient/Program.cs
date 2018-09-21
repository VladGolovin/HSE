namespace TaskPlanner.ConsoleClient
{
    using TaskPlanner.Business.TaskTypeTwo;
    using TaskRunner;
    using TaskRunner.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var taskRunner = new TaskRunner(new List<Action>()
            {
                TaskTypeTwo
            });

            taskRunner.Start();
        }

        private static void TaskTypeTwo()
        {
            var taskPlanner = new TaskPlanner();

            var menuItem = 4;

            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Меню:");
                Console.WriteLine("1 - Добавить работу");
                Console.WriteLine("2 - Добавить исполнителя");
                Console.WriteLine("3 - Вывести план");
                Console.WriteLine("4 - Выход");

                IOHelper.ReadValueSafely(ref menuItem, "пункт меню");

                switch (menuItem)
                {
                    case 1:
                        taskPlanner.Tasks.Add(ReadTask());
                        break;
                    case 2:
                        taskPlanner.Executors.Add(ReadExecutor());
                        break;
                    case 3:
                        PrintTimeTable(taskPlanner.Plan);
                        break;
                    default:
                        continue;
                }
            } while (menuItem != 4);
        }

        private static Task ReadTask()
        {
            Console.WriteLine("Добавление работы.");
            Console.WriteLine();

            var name = "работа";
            IOHelper.ReadValueSafely(ref name, "название работы");

            var duration = 0;
            IOHelper.ReadValueSafely(ref duration, "продолжительность");

            return new Task() { Name = name, Duration = duration };
        }

        private static Executor ReadExecutor()
        {
            Console.WriteLine("Добавление исполнителя.");
            Console.WriteLine();

            var name = "Василий";
            IOHelper.ReadValueSafely(ref name, "имя исполнителя");

            return new Executor() { Name = name };
        }

        private static void PrintTimeTable(List<Tuple<Executor, Task, double, double>> timeTable)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("План:");

            var hash = new Dictionary<Executor, List<Tuple<Task, double, double>>>();

            timeTable.ForEach(tuple =>
            {
                var task = Tuple.Create(tuple.Item2, tuple.Item3, tuple.Item4);

                var tasks = new List<Tuple<Task, double, double>>();

                if (hash.TryGetValue(tuple.Item1, out tasks))
                {
                    tasks.Add(task);
                }
                else
                {
                    hash.Add(tuple.Item1, new List<Tuple<Task, double, double>>() { task });
                };
            });

            hash.Keys.ToList().ForEach(executor =>
            {
                Console.Write($"{executor.Name}:");

                hash[executor].ForEach(taskTuple =>
                {
                    Console.Write($" {taskTuple.Item1.Name}({taskTuple.Item2} - {taskTuple.Item3}) ");
                });

                Console.WriteLine();
            });

            Console.WriteLine("================================================");
        }
    }
}
