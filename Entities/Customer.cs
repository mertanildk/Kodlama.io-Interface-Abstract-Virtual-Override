using Kodlama.io_InterfaceDenemeleri.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_InterfaceDenemeleri.Entities
{
    public class Customer:IEntity //SOMUT SINIFLAR ÇIPLAK KALMAMALI
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; } 
    }
}
