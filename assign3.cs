using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static employeemanagementsystem;

namespace csharpassignment_3
{
    public class program
    {
        public static void Main()
        {
            manager m = new manager();
            m.salary = 35000;
            m.HRA = 450;
            m.TA = 300;
            m.DA = 250;
            m.calculate();
            m.calculatesalary();
            Console.ReadLine();

            marketexecutive obj = new marketexecutive();
            obj.salary = 35000;
            obj.HRA = 500;
            obj.TA = 450;
            obj.DA = 600;
            obj.cal();
            obj.calculatesalary();
            Console.ReadLine();

        }
    }
}
public class employeemanagementsystem
{
    public double salary;
    public double netsalary;
    public double grosssalary;
    public double HRA;
    public double TA;
    public double DA;


    public virtual void calculatesalary()
    {
        netsalary = grosssalary - (HRA + TA + DA);
        Console.WriteLine(netsalary);
    }

    public class manager : employeemanagementsystem
    {
        private double petrolallowances;
        private double foodallowances;
        private double otherallowances;

        public void calculate()
        {
            petrolallowances = 8 * salary / 100;
            foodallowances = 13 * salary / 100;
            otherallowances = 3 * salary / 100;

            grosssalary = petrolallowances + foodallowances + otherallowances;
            Console.WriteLine(grosssalary);


        }
        public override void calculatesalary()
        {
            netsalary = grosssalary - (HRA + TA + DA);
            Console.WriteLine("netsalary of manager = {0} ", netsalary);
            
        }


    }
    public class marketexecutive : employeemanagementsystem
    {
        private double kmtravel;
        private double tourallowances;
        private double telephoneallowances;

        public void cal()
        {
            kmtravel = 5000;
            tourallowances = 5000 / 5;
            telephoneallowances = 1000;

            grosssalary = kmtravel + tourallowances + telephoneallowances;
            Console.WriteLine(grosssalary);
        }
        public override void calculatesalary()
        {
            netsalary = grosssalary - (HRA + TA + DA);
            Console.WriteLine("netsalary of marketexecutive = {0}", netsalary);
            
        }
    }

}