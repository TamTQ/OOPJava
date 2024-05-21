namespace B2
{
    internal class PeopleManager
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Customer> customers = new List<Customer>();

            employees.Add(new Employee("Nguyen A", "Pho A", 5000000));
            employees.Add(new Employee("Nguyen B", "Pho B", 6000000));
            employees.Add(new Employee("Nguyen C", "Pho C", 5500000));

            customers.Add(new Customer("Van A", "Pho D", 100000));
            customers.Add(new Customer("Van B", "Pho E", 20000));
            customers.Add(new Customer("Van C", "Pho F", 150000));

            // Tìm nhân viên có lương cao nhất
            Employee highestPaidEmployee = FindHighestPaidEmployee(employees);
            Console.WriteLine("Highest Paid Employee:");
            highestPaidEmployee.Display();

            // Tìm khách hàng có số dư nhỏ nhất
            Customer lowestBalanceCustomer = FindLowestBalanceCustomer(customers);
            Console.WriteLine("\nCustomer with Lowest Balance:");
            lowestBalanceCustomer.Display();

            // Tìm nhân viên theo tên
            Console.WriteLine("\nEnter the name of the employee to search:");
            string searchName = Console.ReadLine();
            Employee searchedEmployee = FindEmployeeByName(employees, searchName);
            if (searchedEmployee != null)
            {
                Console.WriteLine("Employee Found:");
                searchedEmployee.Display();
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

            // Sử dụng try-catch khi nhập name và paymentPerHour
            try
            {
                Console.WriteLine("\nEnter new employee details:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Salary: ");
                int salary;
                if (!int.TryParse(Console.ReadLine(), out salary))
                {
                    throw new ArgumentException("Invalid salary input.");
                }

                employees.Add(new Employee(name, address, salary));
                Console.WriteLine("New employee added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static Employee FindHighestPaidEmployee(List<Employee> employees)
        {
            Employee highestPaid = employees[0];
            foreach (Employee employee in employees)
            {
                if (employee.GetSalary() > highestPaid.GetSalary())
                {
                    highestPaid = employee;
                }
            }
            return highestPaid;
        }

        static Customer FindLowestBalanceCustomer(List<Customer> customers)
        {
            Customer lowestBalance = customers[0];
            foreach (Customer customer in customers)
            {
                if (customer.GetBalance() < lowestBalance.GetBalance())
                {
                    lowestBalance = customer;
                }
            }
            return lowestBalance;
        }

        static Employee FindEmployeeByName(List<Employee> employees, string name)
        {
            foreach (Employee employee in employees)
            {
                if (employee.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
