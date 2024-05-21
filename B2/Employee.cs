using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    public class Employee : Person
    {
        private int salary;

        public Employee(string name, string address, int salary)
            : base(name, address)
        {
            this.salary = salary;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public int GetSalary()
        {
            return salary;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Address: {GetAddress()}");
            Console.WriteLine($"Salary: {salary}");
        }
    }

}
