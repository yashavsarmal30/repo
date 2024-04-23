using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("C:\\Users\\sbmpc.student\\Pictures\\sbmp alumni.jpg",FileMode.OpenOrCreate);
            int i;
            FileStream f2= new FileStream("E:\\Screenshot (3).png", FileMode.OpenOrCreate);
            while((i = f1.ReadByte())!=-1)
            {
                f2.WriteByte((byte)i);
            }
            f1.Close();
            f2.Close();
            Console.ReadKey();

        }
    }
}
