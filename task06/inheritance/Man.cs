using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    abstract class Man
    {
        private string _name;
        private int _age;
        private string _sex;
        private double _weight;

        public string Name{
            get { return _name; }
        }
        public int Age
        {
            get { return _age; }
        }
        public string Sex
        {
            get { return _sex; }
        }
        public double Weight
        {
            get { return _weight; }
        }

        public void GetName(string name) {
            _name = name;
        }
        public void GetAge(int age)
        {
            _age = age;
        }
        public void GetWeight(double weight)
        {
            _weight = weight;
        }

    }
}
