using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            //ICustomerDal adında bir array oluşturup sql ve oracle i içine ekledik
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            //ICustomerDal adıyla oluşturduğumuz araydeki customerDals ları, ICustomerDal Add classlarına yollayıp foreach ile döndük
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }



        //Metot olarak refactor ettik
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FName = "Engin",
                LName = "Demiroğ",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FName = "Derin",
                LName = "Demiroğ",
                Department = "Computer Science"
            };

            Worker worker = new Worker
            {
                Id = 1,
                FName = "Herhangi",
                LName = "Biri",
                Department = "D Block "
            };

            manager.Add(customer);
            manager.Add(student);
            manager.Add(worker);
        }
    }


    //temel operasyon//soyut nesne şeklinde oluşturup tüm nesneleri ondan implement e ederiz
    //interface ler asla newlenemez Çünkü tek başına hiçbir anlamı yoktur//Soyut nesneler newlenemez
    interface IPerson
    {
        int Id { get; set; }
        string FName { get; set; }
        string LName { get; set; }
    }

    class Customer:IPerson
    {//IPerson interface'innden implement e ettiklerimizi yazmak zorunludur
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Address { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Department { get; set; }
    }class Worker:IPerson
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Department { get; set; }
    }
    class PersonManager
    {//hem Customer hem de Student IPErson interface'ini implemente ettiği için
     //Gönderilebilecek parametre kısmına IPerson yazdık Böylece her ikisini de gönderebiliriz
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FName);
        }
    }
}
