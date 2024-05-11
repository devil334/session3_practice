using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_practice
{
    internal class constant
    {
        public const double PI = 3.14;

        public static void Main(string[] args)
        {
            int radius = 5;
            double area = PI * radius * radius;

            Console.WriteLine("Area of circle with radius {0} is {1:0.00}", radius, area);
        }
    }
}
