using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class Person
    {
        internal string name;
        public int age;
      
        public Person(string n ,int a)
        {
            name = n;
            age = a;
        }

        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }
    }

    class Student:Person
    {
        public int rollNo;

        public Student(string n, int a, int r) : base(n, a)
        {
            rollNo = r;
        }

    }

    class TestDemo
    {
        static void Main(string[] args)
        {
            /*rson p1 = new Person("Demo", 18);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            Console.ReadKey();*/

            Student s1 = new Student("raj", 20, 18);
            Console.WriteLine(s1.name);
            Console.ReadKey();
        }
    }
}

