using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    public class Customer : Person
    {
        private int balance;

        public Customer(string name, string address, int balance)
            : base(name, address)
        {
            this.balance = balance;
        }

        public void SetBalance(int balance)
        {
            this.balance = balance;
        }

        public int GetBalance()
        {
            return balance;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Address: {GetAddress()}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

}
