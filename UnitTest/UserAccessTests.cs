using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDo;

namespace UnitTest
{
    [TestClass]
    public class UserAccessTests
    {
        private const string testUsername = "user";
        private const string testPassword = "password";

        [TestMethod]
        public void createUserTest()
        {
            UserAccess userAccess = new UserAccess();
            userAccess.createUser(testUsername, testPassword);

            Assert.AreEqual(testUsername, userAccess.getUsername(1));
            Assert.AreEqual(testPassword, userAccess.getPassword(1));
        }

        [TestMethod]
        public void getUsernameTest()
        {
            UserAccess userAccess = new UserAccess();
            string username = userAccess.getUsername(1);

            Assert.AreEqual("user", username);
        }

        [TestMethod]
        public void getPasswordTest()
        {
            UserAccess userAccess = new UserAccess();
            string password = userAccess.getPassword(1);

            Assert.AreEqual("password", password);
        }

        public void getTasksTest()
        {
            UserAccess userAccess = new UserAccess();
            List<Task> tasks = userAccess.getTasks(1);

            Assert.AreEqual(1, tasks.Count);
        }

        [TestMethod]
        public void addTaskTest()
        {
            UserAccess userAccess = new UserAccess();
            Task task = new Task(1, "Test Task", DateTime.Now, DateTime.Now, DateTime.Now, false);
            userAccess.addTask(task, 1);
            List<Task> tasks = userAccess.getTasks(1);
            bool taskFound = false;

            foreach (Task t in tasks)
            {
                if (t.TaskName == "Test Task")
                {
                    taskFound = true;
                    break;
                }
            }
            Assert.IsTrue(taskFound);
        }

        public void removeTaskTest()
        {
            UserAccess userAccess = new UserAccess();
            userAccess.removeTask(1, 1);
            List<Task> tasks = userAccess.getTasks(1);
            bool taskRemoved = true;

            foreach (Task task in tasks)
            {
                if (task.Id == 1)
                {
                    taskRemoved = false;
                    break;
                }
            }

            Assert.IsTrue(taskRemoved);
        }

        [TestMethod]
        public void removeAllTasksTest()
        {
            UserAccess userAccess = new UserAccess();
            userAccess.removeAllTasks(1);
            List<Task> tasks = userAccess.getTasks(1);

            Assert.AreEqual(0, tasks.Count);
        }

        [TestMethod]
        public void updateUserTest()
        {
            UserAccess userAccess = new UserAccess();
            string newUsername = "newTestUser";
            string newPassword = "newTestPassword";
            userAccess.updateUser(1, newUsername, newPassword);

            string username = userAccess.getUsername(1);
            string password = userAccess.getPassword(1);

            Assert.AreEqual(username, newUsername);
            Assert.AreEqual(password, newPassword);
        }

        [TestMethod]
        public void updateUsernameTest()
        {
            UserAccess userAccess = new UserAccess();
            string newUsername = "newTestUser";
            userAccess.updateUsername(1, newUsername);
            string username = userAccess.getUsername(1);

            Assert.AreEqual(username, newUsername);
        }

        [TestMethod]
        public void updatePasswordTest()
        {
            UserAccess userAccess = new UserAccess();
            string newPassword = "newTestPassword";
            userAccess.updatePassword(1, newPassword);
            string password = userAccess.getPassword(1);

            Assert.AreEqual(password, newPassword);
        }
    }
}
