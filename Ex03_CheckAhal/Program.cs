using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_CheckAhal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character : ");
            char ch = char.Parse(Console.ReadLine());

            if(65<=ch && ch <= 90 || 97<=ch && ch<=122)
            {
                Console.WriteLine(ch + "는 알파벳 입니다.");
            }
            else
            {
                Console.WriteLine(ch + "는 알파벳이 아닙니다.");
            }
        }
    }
}
