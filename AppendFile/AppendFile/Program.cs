using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileStream fo = new FileStream("E:\\Atharva Gitaye T026\\file1.txt", FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(fo);

            string path = "E:\\file1.txt";

            StreamWriter sw = File.AppendText(path);

            Console.WriteLine("Enter the string, null for termination");

            while (true)
            {
                string str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    break;
                }

                sw.WriteLine(str);
            }

            sw.Flush();
        }
    }
}
