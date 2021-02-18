using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface lerin doğru planlanması
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
                
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
                
            }
        }
    }
    //interface lerin doğru planlanması
    //SOLID, Inteface Segregation
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    //interface lerin doğru planlanması
    class Manager : IWorker, IEat, ISalary
    {
        void IWorker.Work()
        {
            throw new NotImplementedException();
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }        
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
        void IEat.Eat()
        {
            throw new NotImplementedException();
        }
        public void GetSalary()
        {
            throw new NotImplementedException();
        }        
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
