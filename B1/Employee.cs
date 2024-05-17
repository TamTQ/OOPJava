using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    internal abstract class Employee : IEmployee
    {
        private string name;
        private int paymetPerHour;
        public abstract int calculateSalary();
        public abstract string getName();

        public Employee(string name, int paymentPerHour) 
        {
            this.name = name;
            paymetPerHour = paymentPerHour;
        }

        public void setName(string name) 
        {
            this.name = name;
        }

        public String getName(string name)
        {
            return this.name;
        }

        public void setPaymentPerHour(int paymentPerHour) 
        {
            this.paymetPerHour = paymentPerHour;
        }

        public int getPaymetPerHour() 
        {
            return this.paymetPerHour;
        }
    }
}
