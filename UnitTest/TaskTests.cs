using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDo;

namespace UnitTest
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void taskConstructorTest()
        {
            int id = 1;
            string taskName = "Test task";
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            DateTime endTime = DateTime.Now;
            bool completed = false;
            Task task = new Task(id, taskName, startDate, endDate, endTime, completed);

            Assert.IsNotNull(task);
            Assert.AreEqual(id, task.Id);
            Assert.AreEqual(taskName, task.TaskName);
            Assert.AreEqual(startDate, task.Start_date);
            Assert.AreEqual(endDate, task.End_date);
            Assert.AreEqual(endTime, task.End_time);
            Assert.AreEqual(completed, task.Completed);
        }

        [TestMethod]
        public void taskPropertiesTest()
        {
            Task task = new Task(1, "Test task", DateTime.Now, DateTime.Now, DateTime.Now, false);
            task.Id = 2;
            task.TaskName = "Updated task";
            task.Start_date = DateTime.Now.AddDays(2);
            task.End_date = DateTime.Now.AddDays(2);
            task.End_time = DateTime.Now.AddHours(2) ;
            task.Completed = true;

            Assert.AreEqual(2, task.Id);
            Assert.AreEqual("Updated task", task.TaskName);
            Assert.AreEqual(DateTime.Now.AddDays(2), task.Start_date);
            Assert.AreEqual(DateTime.Now.AddDays(2), task.End_date);
            Assert.AreEqual(DateTime.Now.AddHours(2), task.End_time);
            Assert.IsTrue(task.Completed);
        }
    }
}
