using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //가변길이 매개변수
            Console.WriteLine("매개 변수 : 1 2 3 4 5");
            Console.WriteLine("Sum()함수 실행 결과 : " + Sum(1, 2, 3, 4, 5));
            Console.WriteLine("매개 변수 : 1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("Sum()함수 실행 결과 : " + Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //명령된 매개변수
            PrintProfile(name: "안수빈", phone: "010-2467-9504");
            PrintProfile(phone: "010-2467-9504", name: "안수빈" );

            //선택적 매개변수(매개변수 초기화)
            PrintProfile("쫄");
        }

        private static void PrintProfile(string name, string phone = "알고싶지 않음")
        {
            Console.WriteLine("Name: " + name + " Phone: " + phone);
        }

        private static int Sum(params int[] args)
        {
            int result=0;
            foreach(var num in args)
            {
                Console.Write(num);
                result += num;
            }
            return result;
        }
    }
}
