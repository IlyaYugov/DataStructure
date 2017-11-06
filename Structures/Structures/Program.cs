using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStructures.List;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var elem1 = new Node("One", 1, null);
            var elem2 = new Node("Two", 2, elem1);
            var elem3 = new Node("Three", 5, elem2);
            var elem4 = new Node("Four", 4, elem3);
            var elem5 = new Node("Five", 22, elem4);
            var elem6 = new Node("Six", -1, elem5);
            var elem7 = new Node("Seven", 18, elem6);

            List list = new List();
            list.Add(elem7);

            while (list.Current.Next!= null)
            {
                Console.WriteLine(list.Current.Name);
                list.Next();
            }
            Console.WriteLine(list.Current.Name);

            Console.ReadKey();
        }
    }
}
