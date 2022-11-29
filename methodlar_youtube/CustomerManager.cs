using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_simulation 
{
    public class CustomerManager :Customer //ShowCustomer() kalıtımı için inherit ettik
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer + " is added succesfully");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer + " is deleted!");
        }

        public void ShowCustomer(Customer) => Console.WriteLine("Name: " + Name + "\nSurname: " + Surname + "\nCustemer Email: " + Email + "\nWealth: " + Wealth + " $\nOpen Date: " + OpenDate + "\n--------------------------");

    }
}
