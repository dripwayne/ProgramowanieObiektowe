using System;
using System.Collections;
namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek ulamek1 = new Ulamek(2, 5);
            Ulamek ulamek2 = new Ulamek(4, 10);
            Console.WriteLine(ulamek1);
            Console.WriteLine(ulamek2);
            Console.WriteLine(ulamek1+ ulamek2);
            
            Ulamek ulamek3= new Ulamek( 20,50);
            Ulamek[] ulameks = new Ulamek[]
                { ulamek1,
                ulamek3,ulamek2
                };
            Console.WriteLine( ulamek2.CompareTo(ulamek3));

            Array.Sort(ulameks);
          }
            
      
           
        }
    }

