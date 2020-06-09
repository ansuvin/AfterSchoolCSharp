using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine(x + ", " + y);
            swap(ref x,ref y);
            Console.WriteLine(x + ", " + y);

            //out을 이용ㅎㄴ 참조에 의한 매개변수 전달
            int a = 20, b = 3;
            Console.WriteLine($"a={a}, b={b}");
            divide(a, b, out int quotient, out int remainder);
            Console.WriteLine("몫 : " + quotient + " 나머지 : " + remainder);
        }

        private static void divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        private static void swap(ref int x, ref int y)
        {
            int temp;
            temp = y;
            y = x;
            x = temp;
        }
    }
}
