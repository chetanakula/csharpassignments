using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaandcircumference
{
    public class area
    {
        public static void Main(string[] args)
        {
            double r, AREA;
            const double PI = 3.14;
            Console.Write("enter the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            AREA = PI * r * r;
            double circumference = 2 * PI * r;
            Console.WriteLine("area of the circle is : {0}", AREA);
            Console.WriteLine("circumference of circle is : {0}", circumference);
        }
    }
}
