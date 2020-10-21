using CadastroCliente.CadastroContext;
using CadastroCliente.Interfaces;
using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Services
{
    public class AddressService : IAddress
    {
        private readonly ClienteContext _context;
        public AddressService(ClienteContext context)
        {
            _context = context;
        }

        public Address GetAddress(int id)
        {
          return _context.Addresses.FirstOrDefault(e => e.IdAddress == id);
        }

        public void Insert(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void Update(Address address)
        {
            _context.Addresses.Update(address);
            _context.SaveChanges();
        }
    }
}
