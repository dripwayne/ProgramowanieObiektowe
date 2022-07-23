using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ObservableList1<string> obiekt = new ObservableList1<string>();
            obiekt.Add("abd");
            obiekt.Add("dec");
            obiekt.Set(1, "dziala");
            obiekt.RemoveAt(1);
            obiekt.Get(0);
            //obiekt.Get(1);


        }
        class ObservableList1<T>
        {
            public delegate void delegatvoid();
            public delegate string Message(int index, T value);
            public event delegatvoid Added;
            public event delegatvoid Updated;
            public event delegatvoid Deleted;
            protected virtual void OnAdded(T str)
            {
                Console.WriteLine($"Dodano {str}");
            }
            protected virtual void OnUpdated(T str)
            {
                Console.WriteLine($"Zaktualiwano {str}");
            }
            protected virtual void OnRemoved(int str)
            {
                T obj = lista[str];
                Console.WriteLine($"Usunieto {obj}");
            }
            private List<T> lista = new List<T>();

            public void Add(T nazwa)
            {
                lista.Add(nazwa);
                OnAdded(nazwa);
            }
            internal void Get(int its)
            {
                T value = this.lista[its];
                Console.WriteLine(its + " " + value);
            }
            public void Set(int index, T value)
            {
                this.lista[index] = value;
                OnUpdated(value);
            }
            public void RemoveAt(int index)
            {
                lista.RemoveAt(index);
                OnRemoved(index);
            }
            public int lenght { get { return lista.Count; } }

        }

    }

}