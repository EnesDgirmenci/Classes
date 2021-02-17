using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {//Dal=Data Access Layer
        void Add();
        void Update();
        void Delete();

    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Ekleme işlemi tamamlandı");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Silme işlemi tamamlandı");
        }

        public void Update()
        {
            Console.WriteLine("Sql Güncelleme işlemi tamamlandı");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Ekleme işlemi tamamlandı");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Silme işlemi tamamlandı");
        }

        public void Update()
        {
            Console.WriteLine("Sql Güncelleme işlemi tamamlandı");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
