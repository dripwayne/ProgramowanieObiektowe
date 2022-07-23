using System;
namespace Lab_2_zadanie
{
    public class Seller: Person
    {

        public Seller(string name , int age):base(name,age)
        {
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Buyer: " + this.Name + " (" + Age.ToString() + " y.o.)");
        }
    }
}
