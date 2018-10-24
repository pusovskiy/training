using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12REborn
{
    class Cube
    {
        public int ThrowCube() {

            Random rnd = new Random();

            return rnd.Next(1, 7);
        }
    }
}
