using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fo = new FileStream("e:\\file3.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fo);
            Console.WriteLine("Enter the string. null for termination");

            while (true)
            {
                String str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                    break;
                sw.WriteLine(str);
            }
            sw.Flush();
            fo.Close();
        }
    }
}
