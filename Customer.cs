using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW030319_Queue
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        #region ctor
        public Customer()
        {
            
        }
        public Customer(int id, string name, int birthYear, string address, int protection)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;            
        }
        #endregion

        public override string ToString()
        {
            return $"Customer Id: {Id}, Name: {Name}, BirthYear: {BirthYear}, Address: {Address},Protection: {Protection}, TotalPurchases: {TotalPurchases}.";
        }
    }

    class CompareCustomerByProtection : Customer, IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Protection - y.Protection;
        }
    }

    class CompareCustomerByPurchases : Customer, IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.TotalPurchases - y.TotalPurchases;
        }
    }

    class CompareCustomerByYear : Customer, IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.BirthYear - y.BirthYear;
        }
    }
}
