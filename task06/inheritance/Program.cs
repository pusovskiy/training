using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.GetName("valera");
            Console.WriteLine(student1.Name);
            Student student2 = new Student();
            student2.GetWeight (50.23);
            Console.WriteLine(student2.Weight);
            Teacher teacher = new Teacher();
            teacher.GetDegree("professor");
            Console.WriteLine(teacher.Degree);

            Console.ReadKey();
        }
    }
}
