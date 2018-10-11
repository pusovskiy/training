using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    class Teacher : Man
    {
        private int _expirience;
        private string _degree;

        public int Expirience
        {
            get { return _expirience; }
        }
        public string Degree
        {
            get { return _degree; }
        }

        public void GetExp(int expirience)
        {
            _expirience = expirience;
        }
        public void GetDegree(string degree)
        {
            _degree = degree;
        }

    }
}
