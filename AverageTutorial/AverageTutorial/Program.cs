using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            var ave = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average of {0}, {1} and {2} is {3}", num1, num2, num3, ave);
            Console.ReadLine();
        }
    }
}
