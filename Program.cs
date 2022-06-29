using Kodlama.io_InterfaceDenemeleri.Abstract;
using Kodlama.io_InterfaceDenemeleri.Concrete;
using Kodlama.io_InterfaceDenemeleri.Entities;
using System;

namespace Kodlama.io_InterfaceDenemeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new KahveDunyasiCustomerManager(new CustomerCheckManager());
            baseCustomerManager.Add(new Customer
            {
                id = 1,
                Age = 6,
                City = "asd",
                DateOfBirth = "12",
                Name = "mertttt"
            }) ;

            BaseCustomerManager baseCustomerManager1 = new CaribouCustomerManager();
            baseCustomerManager1.Add(new Customer
            {
                id = 1,
                Age = 6,
                City = "asd",
                DateOfBirth = "12",
                Name = "mertttt"
            });
        }
    }
}
