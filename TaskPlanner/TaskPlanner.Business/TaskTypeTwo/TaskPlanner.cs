namespace TaskPlanner.Business.TaskTypeTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Типовая задача №2
    /// 1. Длительность работ произвольная
    /// 2. Работы на зависимы
    /// 3. Прерывания работ разрешены
    /// 4. Исполнители универсальны
    /// 5. Число работников и работ произвольное
    /// 6. Производительность игнорируется
    /// 7. Критерий = кротчайшие сроки
    /// </summary>
    public class TaskPlanner : BaseTaskPlanner
    {
        /// <summary>
        /// Работы
        /// </summary>
        public List<Task> Tasks { get; set; } = new List<Task>();

        /// <summary>
        /// Исполнители
        /// </summary>
        public List<Executor> Executors { get; set; } = new List<Executor>();

        /// <summary>
        /// Расписание
        /// </summary>
        public List<Tuple<Executor, Task, double, double>> Plan { get { return _plan(); } }

        /// <summary>
        /// Количество часов, которое будет затрачено на выполнение всех работ исполнителями.
        /// </summary>
        public double Duration
        {
            get
            {
                var maxTaskDuration = Tasks.Max(t => t.Duration);

                var avarageDuration = Tasks.Sum(t => t.Duration) / Executors.Count;

                return Math.Max(maxTaskDuration, avarageDuration);
            }
        }

        /// <summary>
        /// Планирует расписание
        /// </summary>
        /// <returns>расписание</returns>
        private List<Tuple<Executor, Task, double, double>> _plan()
        {
            var duration = Duration;

            var tasks = new Stack<Task>(Tasks.Select(task => (Task)task.Clone()));

            var plan = new List<Tuple<Executor, Task, double, double>>();

            Executors.ForEach(executor =>
            {
                var executorTime = duration;

                double taskStart = 0;

                double taskEnd = 0;
                
                var order = 1;

                while (executorTime > 0 && tasks.Count > 0)
                {
                    var task = tasks.Pop();

                    if (task.Duration > executorTime)
                    {
                        tasks.Push(new Task() {
                            Name = task.Name,
                            Duration = task.Duration - executorTime
                        });

                        task.Duration = executorTime;

                        taskEnd = taskStart + executorTime;
                    }
                    else
                    {
                        taskEnd = taskStart + task.Duration;
                    }

                    plan.Add(new Tuple<Executor, Task, double, double>(executor, task, taskStart, taskEnd));

                    executorTime -= task.Duration;

                    taskStart += task.Duration;

                    order++;
                }
            });

            return plan;
        }
    }
}
