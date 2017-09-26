using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sweets = 40;
            const int students = 14;
            int studentsSweets;
            int teachersSweets;

            studentsSweets = sweets / students;
            teachersSweets = sweets % students;
            Console.WriteLine("Each student will get {0} sweets.", studentsSweets);
            Console.WriteLine("The teacher will be left with {0} sweets.", teachersSweets);
            //Console.ReadLine();
        }
    }
}
