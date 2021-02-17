using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {//37.Ders
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Console.WriteLine("-----------------------------------");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.WriteLine("-----------------------------------");



            //38.Ders
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FName = "Engin";
            customer.LName = "Demiroğ";
            customer.City = "Ankara";
            Console.WriteLine("-----------------------------------");
            Customer customer2 = new Customer
            {Id=2,FName="Derin",LName="Demiroğ",City="Anakara",
            };
            Console.WriteLine(customer2.FName);
            Console.WriteLine("-----------------------------------");




            Console.ReadLine();
        }
    }
}
