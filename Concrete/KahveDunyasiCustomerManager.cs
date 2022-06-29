using Kodlama.io_InterfaceDenemeleri.Abstract;
using Kodlama.io_InterfaceDenemeleri.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_InterfaceDenemeleri.Concrete
{
    internal class KahveDunyasiCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public KahveDunyasiCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);

            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
