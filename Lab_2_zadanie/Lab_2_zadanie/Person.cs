﻿using System;
namespace Lab_2_zadanie
{
    public abstract class Person:IThing
    {
        private string name;
        public string Name { get => name; }

        private int age;
        public int Age { get => age; }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void Print(string prefix);
        
    }
}
