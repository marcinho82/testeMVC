using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroCliente.CadastroContext;
using CadastroCliente.Models;
using CadastroCliente.Interfaces;

namespace CadastroCliente.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsers _user;
        private readonly IAddress _address;
        public UsersController(IUsers user, IAddress address)
        {
            _user = user;
            _address = address;
        }

        // GET: Users
        public IActionResult Index()
        {           
           return View(_user.GetUsers());
        }

        // GET: Users/Details/5
        public IActionResult Details(int id)
        {                 

            return View(_user.GetUsersId(id));
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Address address)
        {
          
            if (ModelState.IsValid)
            {
               _user.Insert(address.Users);
            
            }           
            return RedirectToAction("Index", _user.GetUsers());
        }

        // GET: Users/Edit/5
        public IActionResult Edit(int id)
        {            
            return View(_user.GetUsersId(id));
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Address address)
        {
            if (ModelState.IsValid)
            {
                _user.UpdateUser(address.Users);
                return RedirectToAction(nameof(Index));
            }
            return View(address.Users);
        }      

       
    }
}
