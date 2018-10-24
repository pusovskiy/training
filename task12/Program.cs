using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12REborn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Timer timer = new Timer(500, true);
            timer.Tick += GetCubeDigit;
            timer.Start();


        }

        

        public static void GetCubeDigit()
        {
            Cube cube = new Cube();
            Console.WriteLine(cube.ThrowCube());
        }
    }
}
