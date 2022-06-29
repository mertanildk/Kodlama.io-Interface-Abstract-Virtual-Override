using Kodlama.io_InterfaceDenemeleri.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_InterfaceDenemeleri.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Remove(Customer customer);
        void Rename(Customer customer);

    }
}
