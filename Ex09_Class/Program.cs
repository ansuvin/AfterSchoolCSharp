using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Class
{
    class A
    {
        public int value1 = 10;
        protected int value2 = 20;
        private int value3 = 30;

        public class C : A     //이너클래스로 들어옴
        {
            public int GetValue3()
            {
                return value3;      //private접근 지정자여도 접근 가능
            }
        }

    }

    class B : A
    {
        public int GetValue1()
        {
            return value1;
        }
        public int GetValue2()
        {
            return value2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine($"a.value1: {a.value1}");
            //Console.WriteLine($"a.value2: {a.value2}");  protected로 지정되어 있어 상속 받은 값만 접근 할 수 ㅇㅆ다.

            B b = new B();
            Console.WriteLine($"b.value1: {b.GetValue1()}");
            Console.WriteLine($"b.value2: {b.GetValue2()}");
            
            var c = new A.C();      //A의 이너클래스 C
            Console.WriteLine($"c.value3: {c.GetValue3()}");

        }
    }
}
