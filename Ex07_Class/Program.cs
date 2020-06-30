using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Class
{
    class Cube
    {
        static int countOfInstance;

        int x, y, z;

        public void GetVolume()
        {

            Console.WriteLine("생성된 Cube의 개수" + countOfInstance);
            Console.WriteLine("Cube의 부피" + x * y * z);
        }

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            countOfInstance++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cube cube1 = new Cube(2, 3, 4);
            cube1.GetVolume();

            Cube cube2 = new Cube(5, 5, 5);
            cube2.GetVolume();
        }
    }
}

