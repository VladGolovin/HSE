namespace TaskPlanner.Business
{
    using System;
    using System.Collections.Generic;

    public abstract class BaseTaskPlanner
    {        
        /// <summary>
        /// Работы
        /// </summary>
        List<ITask> Tasks { get; set; }

        /// <summary>
        /// Исполнители
        /// </summary>
        List<IExecutor> Executors { get; set; }

        /// <summary>
        /// Расписание
        /// </summary>
        /// <returns>Перечень работ</returns>
        List<Tuple<IExecutor, ITask, double, double>> Plan { get; }
    }
}
