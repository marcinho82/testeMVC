using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.CadastroContext
{
    public class ClienteContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public ClienteContext (DbContextOptions<ClienteContext> options) :  base(options)  { }
    }
}
