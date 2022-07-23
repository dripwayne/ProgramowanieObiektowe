using System;

namespace Lab_2
{
    public class Task
    {
        
        private string name;
        public string Name { get => name; }

        private TaskStatus status;
        public TaskStatus Status { get => status; set { this.status = value; } }

        public Task(string name, TaskStatus status)
        {
            this.name=name;
            this.status = status;
        }
        public override string ToString()
        {
            return $"{name} [{status.ToString()}]";
        }

       
        public bool Equals(Task other)
        {
            return this.name ==other.name && this.status==other.status;
        }
      
    }
}
