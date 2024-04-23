using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpecifiers;

namespace Assembly2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("raj", 17);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
        }
    }
}
