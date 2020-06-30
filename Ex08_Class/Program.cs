using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Class
{
    class Class1
    {
        int a, b, c;

        public Class1()
        {
            Console.WriteLine("Class1() 호출");
            a = 1;
            b = 0;
            c = 0;
        }

        public Class1(int b) :this () //위에 생성자를 먼저 호출하고 실행
        {
            Console.WriteLine($"Class1({b}) 호출");
            this.b = b;
            c = 0;
        }
        
        public Class1(int b, int c) : this(b)
        {
            Console.WriteLine($"Class1({b},{c}) 호출");
            this.c = c;
        }

        public void printField()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.printField();
            
            Class1 c2 = new Class1(2);
            c2.printField();
            
            Class1 c3 = new Class1(2,3);
            c3.printField();
        }
    }
}
