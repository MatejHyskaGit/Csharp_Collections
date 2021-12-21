using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>(3) { new Student("Adam"), new Student("Katka", 15)};
            foreach (var item in list)
            {
                if (item.Age != 0)
                {
                    Console.WriteLine(item.Name + ": " + item.Age);
                    
                }
                else Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n############################\n");

            Console.WriteLine("Kapacita: " + list.Capacity);
            Console.WriteLine("Počet: " + list.Count);
            Console.WriteLine(list[0].Name);

            Console.WriteLine("\n############################\n");

            list.Clear();
            list.Add(new Student("Lukáš", 24));
            Console.WriteLine(list.Contains(list[0]));


        }
    }
}
