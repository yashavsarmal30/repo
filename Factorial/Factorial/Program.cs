using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public static class Program
    {
        public static long GetFact(this int? number)
        {
            long fact = 1;
                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                return fact;

        }
    }
}
