using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer{FName= "Engin" },
                new Student{FName="Derin" },
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FName);
            }
            Console.ReadLine();
        }
    }
    class Person2
    {

    }
    class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
    //Bir nesneyi sadece bir kere inheritance alabiliriz //interfaceler inheritance gibi çalışır
    //birden fazla interface implementasyon yapabiliriz  //
    class Customer:Person
    {
        public string City { get; set; }

    }class Student:Person
    {
        public string Department { get; set; }

    }
}
