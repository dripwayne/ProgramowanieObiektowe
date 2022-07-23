using System;
namespace Lab_2
{
    public class Person
    {
        
        protected string name;
        public string Name { get => name; }

        protected int age;
        public int Age { get => age; }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public bool Equals(Person person)
        {
            return person.name == this.name && person.age == this.age;
        }

        public override string ToString()
        {
            return this.name+" "+"("+age.ToString()+" y.o)";
        }
    }
}
