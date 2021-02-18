using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }

    }
}
