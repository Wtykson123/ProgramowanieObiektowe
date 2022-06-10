using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        private string name;
        private int age;
        public string Name { get => name; }
        public int Age { get => age; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            return name == other.Name && age == other.Age;
        }
        public override string ToString()
        {
            return $"{name} {age}";
        }
    }
    public class Task
    {
        private string name;

        public string Name { get => name; }
        public TaskStatus Status { get; set; }
        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.Status = status;
        }
    }
    public enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected,
    }
    public class Student : Person
    {
        private string group;
        public string Group { get => group; }
        private List<Task> tasks = new List<Task>();

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
        }
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }
        public void AddTask(string TaskName, TaskStatus taskStatus)
        {
            tasks.Add(new Task(TaskName, taskStatus));
        }
        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            tasks[index].Status = taskStatus;
        }
        public override string ToString()
        {
            return $"Student : {this.Name} {this.Age} \nGroup: {group} \nTasks: {tasks}\n";
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {

        }
        public override string ToString()
        {
            return $"Teacher : {this.Name} {this.Age}";
        }
    }
    public class Classroom
    {
        private string name;
        private Person[] persons;
        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }
        public override string ToString()
        {
            string toString = "";
            foreach (Person person in persons)
            {
                toString += person.ToString() + "\n";
            }
            return $"Classroom: {name} {toString}";
        }
    }


}
