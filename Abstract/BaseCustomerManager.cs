using Kodlama.io_InterfaceDenemeleri.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_InterfaceDenemeleri.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Eklendi "+customer.Name);
        }

        public  void Remove(Customer customer)
        {
            Console.WriteLine("Silindi "+ customer.Name);
        }

        public void Rename(Customer customer)
        {
            Console.WriteLine("Yenilendi "+ customer.Name);
        }
    }
}
