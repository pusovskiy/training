using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    class Student : Man
    {
        private int _yearOfStudy;

        public int YearOfStudy
        {
            get { return _yearOfStudy; }
        }
        public void GetYear(int yearOfStudy)
        {
            _yearOfStudy = yearOfStudy;
        }
        public void CountYear(int yearOfStudy)
        {
            _yearOfStudy = yearOfStudy;
            yearOfStudy++;
        }
    }
}
