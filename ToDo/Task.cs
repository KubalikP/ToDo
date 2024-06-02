using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Task
    {
        private int id;
        private int userId;
        private string taskName;
        private DateTime start_date;
        private DateTime end_date;
        private DateTime end_time;
        private bool completed;

        public Task(int id, string taskName, DateTime start_date, DateTime end_date, DateTime end_time, bool completed)
        {
            this.id = id;
            this.taskName = taskName;
            this.start_date = start_date;
            this.end_date = end_date;
            this.end_time = end_time;
            this.completed = completed;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }

        public DateTime Start_date
        {
            get { return start_date; }
            set { start_date = value; }
        }

        public DateTime End_date
        {
            get { return end_date; }
            set { end_date = value; }
        }

        public DateTime End_time
        {
            get { return end_time; }
            set { end_time = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }
    }
}
