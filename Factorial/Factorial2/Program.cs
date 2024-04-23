using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorial;

namespace Factorial2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number = ");
            int? input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {input} = {input.GetFact()}");
            Console.ReadLine();
        }
    }
}
