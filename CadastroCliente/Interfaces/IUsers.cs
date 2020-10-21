using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Interfaces
{
    public interface IUsers
    {
        public List<Users> GetUsers();
        public void Insert(Users users);
        public void UpdateUser(Users users);
        public Users GetUsersId(int id);        


    }
}
