using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofintergers
{
    public class sumarray
    {
        public static void Main(string[] args)
        {
            int[] number = { 10, 30, 50, 90 };
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + number[i];
            }
            Console.WriteLine(" sum is {0}", sum);
        }
    }
}
