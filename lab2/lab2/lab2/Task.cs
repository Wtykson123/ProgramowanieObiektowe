<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public enum TaskStatus
    {

        Waiting,
        Progress,
        Done,
        Rejeted,
        Rejected,
    }
    public class Task
    {

        private string name;
        private TaskStatus status;

        public string Name { get => this.name; }
        public TaskStatus Status { get => this.status; }

        public Task(string name, TaskStatus status)
        {

            this.name = name;
            this.status = status;

        }

        public override string ToString()
        {
            return $"Task: {base.ToString()}";

        }




    }

}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public enum TaskStatus
    {

        Waiting,
        Progress,
        Done,
        Rejeted,
        Rejected,
    }
    public class Task
    {

        private string name;
        private TaskStatus status;

        public string Name { get => this.name; }
        public TaskStatus Status { get => this.status; }

        public Task(string name, TaskStatus status)
        {

            this.name = name;
            this.status = status;

        }

        public override string ToString()
        {
            return $"Task: {base.ToString()}";

        }




    }

}
>>>>>>> 20a94b11db97ee0397c0cd48574142054d95e370
