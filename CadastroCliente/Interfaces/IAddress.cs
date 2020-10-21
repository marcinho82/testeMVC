using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Interfaces
{
    public interface IAddress
    {
        public void Insert(Address address);
        public void Update(Address address);
        public Address GetAddress(int id);
         
    }
}
