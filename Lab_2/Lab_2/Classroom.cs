using System;
namespace Lab_2
{
    public class Classroom

    {
        private string name;
        public string Name { get => name; }

        private Person[] person;

        public Classroom(string name, Person[] person)
        {
            this.name = name;
            this.person = person;
        }
        override public string ToString()
        {
            string result = "Classroom: " + this.name + "\n\n";
            foreach (var p in person)
            {
                result += p.ToString() + "\n";
            }
            return result;
        }
    }
}