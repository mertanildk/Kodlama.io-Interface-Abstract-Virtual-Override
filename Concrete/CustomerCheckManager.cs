using Kodlama.io_InterfaceDenemeleri.Abstract;
using Kodlama.io_InterfaceDenemeleri.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_InterfaceDenemeleri.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;//fake doğrulanmış  gösteriyoruz
        }
    }
}
