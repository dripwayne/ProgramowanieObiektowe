﻿using System;
namespace Lab_2_zadanie
{
    public class Meat:Product
    {
        private double weight;
        public double Weight { get => weight; }
        public Meat(string name, double weight):base(name)
        {
            this.weight = weight;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine( prefix + this.Name + " (" + weight.ToString() + " kg)");
        }
    }
}
