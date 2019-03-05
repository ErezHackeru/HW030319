using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW030319_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(new Customer(1, "Dubi", 1991, "Jerusalem", 52));
            myQueue.Enqueue(new Customer(2, "Beni", 1965, "Hebron", 91));
            myQueue.Enqueue(new Customer(3, "Koby", 1998, "Monako", 43));
            Console.WriteLine($"The amount of customers in the Q is: {myQueue.Count}.");
            Console.WriteLine("======================================================");
            List<Customer> customersList = new List<Customer>()
            {
                new Customer(1, "Dubi", 1991, "Jerusalem", 52),
                new Customer(2, "Beni", 1965, "Hebron", 91),
                new Customer(3, "Koby", 1998, "Monako", 43)
            };
            customersList.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("======================================================");
            myQueue.Init(customersList);
            Console.WriteLine("THe customers list:");
            int MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("======================================================");
            myQueue.Init(customersList);
            myQueue.SortByBirthYear();
            Console.WriteLine("THe customers list SortByBirthYear:");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("======================================================");
            myQueue.Init(customersList);
            myQueue.SortByProtection();
            Console.WriteLine("THe customers list SortByProtection:");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("======================================================");
            myQueue.Init(customersList);
            myQueue.SortByTotalPurchases();
            Console.WriteLine("THe customers list SortByTotalPurchases:");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("======================================================");
            myQueue.Init(customersList);
            myQueue.DeQueueCustomers(2);
            Console.WriteLine("THe customers list DeQueueCustomers(2):");
            MyQueLength = myQueue.Count;
            for (int i = 0; i < MyQueLength; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("======================================================");

            myQueue.Init(customersList);
            Console.WriteLine($"The customer with most protectzia is: {myQueue.DeQueueProtectiza()}.");
            Console.WriteLine($"The Next customer is: {myQueue.WhoIsNext()}.");

            Console.ReadKey();
        }
    }
}
