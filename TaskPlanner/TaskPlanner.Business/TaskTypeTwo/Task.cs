namespace TaskPlanner.Business.TaskTypeTwo
{
    using System;

    public class Task : ITask, ICloneable
    {
        public string Name { get; set; }

        public double Duration { get; set; }

        public object Clone()
        {
            return new Task()
            {
                Name = Name,
                Duration = Duration
            };
        }
    }
}
