using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapintergers
{
    public class swapping
    {
        public static void Main(string[] args)
        {
            int number1, number2, temp;

            Console.WriteLine("\nInput the first number :");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInput the second number :");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("\nAfter swapping :");
            Console.WriteLine("\nFirst number : " + number1);
            Console.WriteLine("\nSecond number : " + number2);
            Console.Read();

        }
       
    }
}
