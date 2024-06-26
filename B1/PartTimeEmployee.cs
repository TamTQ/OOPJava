﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    public class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int CalculateSalary()
        {
            return workingHours * paymentPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + $", Type: Part-Time, Working Hours: {workingHours}";
        }
    }

}
