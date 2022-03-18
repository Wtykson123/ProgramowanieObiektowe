using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student : Person
    {

        protected String group;
        protected List<Task> tasks;

        public string Group { get => this.group; }

        public Student(String name, int age, String group) : this(name, age, group, new List<Task> ())
        {
            this.group = group;


        }

        internal void AddTask(string v, TaskStatus waiting)
        {
            throw new NotImplementedException();
        }

        public Student(String name, int age, String group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;

        }

        public override string ToString()
        {
            return $"Student: {base.ToString()}";
        }

        internal void UpdateTask(int v, TaskStatus done)
        {
            throw new NotImplementedException();
        }
    }
}
