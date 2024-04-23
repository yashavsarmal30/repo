using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fi = new FileStream("e:\\file6.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fi);
            string str1;
            Console.WriteLine("The contents of file are: ");
            while((str1 = sr.ReadLine()) != null)
            {
                Console.WriteLine(str1);
            }
            sr.Close();
            fi.Close();
            Console.ReadKey();
        }
    }
}
