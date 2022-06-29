using Kodlama.io_InterfaceDenemeleri.Abstract;
using Kodlama.io_InterfaceDenemeleri.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_InterfaceDenemeleri.Concrete
{
    public class CaribouCustomerManager:BaseCustomerManager
    {
        public override void Add(Customer customer)
        {
            Console.WriteLine("karibuya eklendi");
            Console.Write("Caribu Serverine ");
            base.Add(customer);
        }
    }
}
