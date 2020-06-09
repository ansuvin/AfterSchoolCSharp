using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_PrintOddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("정수를 입력하세요 : ");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
