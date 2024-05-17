using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHour;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHour) : base(name, paymentPerHour)
        {
            this.workingHour = workingHour;
        }

        public override int calculateSalary()
        {
            return this.workingHour*this.getPaymetPerHour();
        }

        public override string getName()
        {
            return this.getName();
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: {calculateSalary()}";
        }
    }
}
