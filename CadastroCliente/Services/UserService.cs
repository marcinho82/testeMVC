using CadastroCliente.CadastroContext;
using CadastroCliente.Interfaces;
using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Services
{
    public class UserService : IUsers
    {
        private readonly ClienteContext _context;

        public UserService(ClienteContext context)
        {
            _context = context;
        }

        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }

        public Users GetUsersId(int id)
        {
          
            return _context.Users.FirstOrDefault(e => e.IdUser == id);
        }

        public int Insert(Users users)
        {
           _context.Users.Add(users);
           _context.SaveChanges();          

            return users.IdUser;

        }

        public void UpdateUser(Users users)
        {
            try
            {
                _context.Update(users);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {                
                throw;            
            }
        }
    }
}
