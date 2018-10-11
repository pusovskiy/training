using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_1
{
    class Rose : Flowers
    {
        private int _discount;

        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public override int GetCost()
        {
            int sum = base.GetCost() - (base.GetCost() * _discount / 100);
            return sum;
        }
        
    }
}
