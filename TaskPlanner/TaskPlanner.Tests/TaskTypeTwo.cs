using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskPlanner.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using TaskPlanner.Business;
    using TaskPlanner.Business.TaskTypeTwo;

    [TestClass]
    public class TaskTypeTwo
    {
        private readonly List<Task> _tasks;

        private readonly List<Executor> _executors;

        private readonly TaskPlanner _taskPlanner;

        [TestMethod]
        public void DurationCorrect()
        {
            Assert.AreEqual(3.5, _taskPlanner.Duration);
        }

        [TestMethod]
        public void AllTasksPresent()
        {
            var plan = _taskPlanner.Plan;

            _tasks.ForEach(task =>
            {
                Assert.IsTrue(plan.Any(t => t.Item2.Name.Equals(task.Name)));
            });
        }

        [TestMethod]
        public void AllExecutorsUsed()
        {
            var plan = _taskPlanner.Plan;

            _executors.ForEach(executor =>
            {
                Assert.IsTrue(plan.Any(t => t.Item1.Name.Equals(executor.Name)));
            });
        }

        public TaskTypeTwo()
        {
            _tasks = new List<Task>()
            {
                new Task() { Name = "A", Duration = 1 },
                new Task() { Name = "B", Duration = 3 },
                new Task() { Name = "C", Duration = 2 },
                new Task() { Name = "D", Duration = 1 }
            };

            _executors = new List<Executor>()
            {
                new Executor() { Name = "Василий" },
                new Executor() { Name = "Пётр" }
            };

            _taskPlanner = new TaskPlanner()
            {
                Tasks = _tasks,
                Executors = _executors
            };
        }
    }
}
