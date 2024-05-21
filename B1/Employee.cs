using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    public abstract class Employee : IEmployee
    {
        protected string name;
        protected int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetPaymentPerHour()
        {
            return paymentPerHour;
        }

        public void SetPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int CalculateSalary();

        public override string ToString()
        {
            return $"Name: {name}, Payment Per Hour: {paymentPerHour}";
        }
    }

}
