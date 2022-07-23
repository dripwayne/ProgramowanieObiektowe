using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2_zadanie
{
    public class Shop : IThing
    {
        private string name;
        public string Name { get => name; }
        private Person[] people;
        private Product[] products;
        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }
        public void Print()
        {
            Console.WriteLine("Shop: " + this.name);
            Console.WriteLine("--People--");
            foreach (var p in people)
            {
                p.Print("\t");
            }
            foreach (var p in products)
            {
                p.Print("\t");
            }
        }
    }
}
