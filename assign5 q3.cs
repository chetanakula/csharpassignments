using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Name { get; set; }

        public int salary { get; set; }

        public int phonenumber { get; set; }
        public string city { get; set; }
    }

    public class employeedetails
    {
        public static void Main()
        {
            List<Employee> Employess = new List<Employee>();
            Employee E1 = new Employee();
            {
                E1.Eid = 101;
                E1.Name = " chetan";
                E1.salary = 45000;
                E1.phonenumber = 1234567890;
                E1.city = "palakollu";
            }
            Employee E2 = new Employee();
            {
                E2.Eid = 103;
                E2.Name = " satya";
                E2.salary = 40000;
                E2.phonenumber = 1234509876;
                E2.city = "narsapuram";
            }
            Employee E3 = new Employee();
            {
                E3.Eid = 105;
                E3.Name = " teja";
                E3.salary = 55000;
                E3.phonenumber = 0987654321;
                E3.city = "palakollu";
            }
            Employess.Add(E1); Employess.Add(E2); Employess.Add(E3);
            foreach (Employee e in Employess)
            {
                Console.WriteLine(e.Eid + " " + e.Name + " " + e.salary + " " + e.phonenumber + " " + e.city + " ");
            }
            Console.ReadLine();

            Console.WriteLine("Total number of employess:");
            Console.WriteLine(Employess.Count);
            Console.ReadLine();


        }

    }



}

