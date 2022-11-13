using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    internal class assign5_q2
    {
        public static void Main()
        {
            List<object> emp = new List<object>();
            emp.Add(1);
            emp.Add("satya");
            emp.Add("pkl");
            emp.Add(16000);
            emp.Add(1234567890);
            foreach(object i in emp)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count is:");
            Console.WriteLine(emp.Count());
            Console.ReadLine();
            
        }
      
    }
}
