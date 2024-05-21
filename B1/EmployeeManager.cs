using System.Collections.Generic;

namespace B1
{
    internal class EmployeeManager
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>();

            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Find Employee with Highest Salary");
                Console.WriteLine("3. Find Employee by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        FindEmployeeWithHighestSalary(employees);
                        break;
                    case 3:
                        FindEmployeeByName(employees);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private static void AddEmployee(List<IEmployee> employees)
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter payment per hour: ");
                int paymentPerHour = int.Parse(Console.ReadLine());

                Console.Write("Is this a full-time employee? (yes/no): ");
                string type = Console.ReadLine();

                if (type.ToLower() == "yes")
                {
                    employees.Add(new FullTimeEmployee(name, paymentPerHour));
                }
                else
                {
                    Console.Write("Enter working hours: ");
                    int workingHours = int.Parse(Console.ReadLine());
                    employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
                }

                Console.WriteLine("Employee added successfully.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }

        private static void FindEmployeeWithHighestSalary(List<IEmployee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            IEmployee highestSalaryEmployee = null;
            int highestSalary = 0;

            foreach (var employee in employees)
            {
                int salary = employee.CalculateSalary();
                if (salary > highestSalary)
                {
                    highestSalary = salary;
                    highestSalaryEmployee = employee;
                }
            }

            if (highestSalaryEmployee != null)
            {
                Console.WriteLine("Employee with highest salary:");
                Console.WriteLine(highestSalaryEmployee);
            }
        }

        private static void FindEmployeeByName(List<IEmployee> employees)
        {
            Console.Write("Enter the name of the employee: ");
            string name = Console.ReadLine();

            foreach (var employee in employees)
            {
                if (employee.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(employee);
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

    }
}
