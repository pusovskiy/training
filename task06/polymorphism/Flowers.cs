using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_1
{
    abstract class Flowers
    {
        private int _cost;
        private int _count;        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public virtual int GetCost()
        {
            int sum = _cost * Count;
            return sum; 
        }


    }
}
