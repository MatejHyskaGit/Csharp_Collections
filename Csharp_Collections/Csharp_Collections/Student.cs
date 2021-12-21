using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Collections
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name)
        {
            Name = name;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
