using System;
using System.Collections.Generic;
namespace Lab_2
{
    public class Student : Person
    {
        protected string group;
        public string Group { get => group; }

        protected List<Task> tasks = new List<Task>();

        public Student(string name, int age, string group) : base(name, age)
        {

            this.group = group;
        }
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }
        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            this.tasks.Add(new Task(taskName, taskStatus));
        }


        public void Update(int index, TaskStatus taskStatus)
        {
            this.tasks[index].Status = taskStatus;
        }
        public string RenderTask(string prefix = "\t")
        {
            string resoult = "";
            foreach (var t in this.tasks)
            {
                resoult += prefix + t.ToString() + "n";
            }
            return resoult;
        }
        public bool Equals(Student other)
        {
            return base.Equals(other) && this.name == other.name && this.group == other.group && this.age == other.age;
        }
        private bool SequenceEqual(List<Task> a, List<Task> b)
        {
            if (a.Count != b.Count) return false;
            for(int i = 0; i < a.Count; i++)
            {
                if (!a[i].Equals(b[i])) return false;
            }
            return true;
        }
        
    }
}
