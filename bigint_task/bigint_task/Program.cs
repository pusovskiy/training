using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigint_task
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInt bi = 10012322200;
            Console.WriteLine(bi.Add(8));
            Console.WriteLine(bi.Subtraction(2));
            bi.Multiply(100);
            Console.ReadKey();
        }
    }
}
