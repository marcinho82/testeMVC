using CadastroCliente.CadastroContext;
using CadastroCliente.Interfaces;
using CadastroCliente.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            var _add =  _context.Addresses.FirstOrDefault(e => e.IdUser == id);
            var user = _context.Users.FirstOrDefault(e => e.IdUser == id);
            _add.Users = user;
            return _add;
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
