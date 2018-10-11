using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_1
{
    class GoldenFlower : Flowers
    {
        
        public override int GetCost()
        {
            int sum = 2 * base.GetCost();
            return sum;
        }
    }
    
}
