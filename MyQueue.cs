using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW030319_Queue
{
    class MyQueue
    {
        List<Customer> customers = new List<Customer>();
        public int Count
        {
            get
            {
                return customers.Count();
            }
        }
        public void Enqueue(Customer customer)
        {
            customers.Add(customer);
        }
        public Customer Dequeue()
        {
            Customer First = customers[0];
            customers.RemoveAt(0);
            return First;
        }
        public void Init(List<Customer> customers)
        {
            this.customers.Clear();
            for (int i = 0; i < customers.Count(); i++)
            {
                this.customers.Add(customers[i]);
            }
            //this.customers = customers;
        }
        public void Clear()
        {
            customers.Clear();
        }
        public Customer WhoIsNext() // Peep
        {
            return customers[0];
        }
        public void SortByProtection()
        {
            customers.Sort(new CompareCustomerByProtection());
        }
        public void SortByTotalPurchases()
        {
            customers.Sort(new CompareCustomerByPurchases()); 
        }
        public void SortByBirthYear()
        {
            customers.Sort(new CompareCustomerByYear());
        }
        public List<Customer> DeQueueCustomers(int customersNumberToReduce)
        {
            for (int i = 0; i < customersNumberToReduce; i++)
            {
                customers.RemoveAt(0);
            }
            return customers;
        }
        public void AniRakSheela(Customer customer) // Push
        {
            List<Customer> NewList = new List<Customer>();
            NewList.Add(customer);
            for (int i = 0; i < customers.Count(); i++)
            {
                NewList.Add(customers[i]);
            }
            customers = NewList;
        }
        public Customer DeQueueProtectiza()
        {
            int MaxProtection = 0;
            foreach (Customer customer in customers)
            {
                if (customer.Protection > MaxProtection)
                    MaxProtection = customer.Protection;
            }

            for (int i = 0; i < customers.Count(); i++)
            {
                if (customers[i].Protection == MaxProtection)
                {
                    return customers[i];
                }
            }
            return customers[0];
        }
    }
}
