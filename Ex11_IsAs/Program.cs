using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_IsAs
{
    class Program
    {

        static void Main(string[] args)
        {
            Object[] objectArray = new object[] { 8.9, "dog", 6, "c", null, 15.99, 754, true };
            Console.WriteLine(Sum(objectArray));
        }
        static double Sum(object[] n)
        {
            double result = 0;
            foreach (object i in n)
            {
                if (i is double)
                {
                    result += (double)i;
                }
            }
            return result;
        }
    }
}
