using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return 8 * this.getPaymetPerHour();
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
