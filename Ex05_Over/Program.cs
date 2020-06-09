using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Over
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plus(1,2)");
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine("Plus(3.5,2.7)");
            Console.WriteLine(Plus(3.5, 2.7));

        }

        private static int Plus(int v1, int v2)
        {
            return v1 + v2;
        }
        private static double Plus(double v1, double v2)
        {
            return v1 + v2;
        }
    }
}
