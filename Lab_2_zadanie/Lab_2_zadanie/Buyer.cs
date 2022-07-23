using System;
using System.Collections.Generic;
namespace Lab_2_zadanie
{
    public class Buyer:Person
    {
        protected List<Product> products = new List<Product>();

        public Buyer(string name, int age):base(name,age)
        {
            
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }
        public void RemoveProduct(int index)
        {
            this.products.RemoveAt(index);
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix+"Buyer: "+this.Name+" ("+Age.ToString()+" y.o.)");
            Console.WriteLine("\t"+"\t"+"--Products:--");
            if (products.Count > 0)
            {
                foreach(var i in products)
                {
                    i.Print(prefix + "\t");
                }
            }
        }
    }
}
