using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhereToEat.Data;
using WhereToEat.Models;
using WhereToEat.ViewModels;

namespace WhereToEat.Controllers
{
    public class UserController : Controller
    {
        private RestaurantDbContext context;

        public UserController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }
   
        public IActionResult Login(string emailaddress, string password)
        {
            if (emailaddress == emailaddress && password == password)
            {
                return View();
            }

            else if (emailaddress != emailaddress || password != password)
            {
                return View("Register");
            }

            else if (emailaddress != emailaddress && password != password)
            {
                return View();
            }

            else
            {
                return View();
            }
        }

        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Name = addUserViewModel.Name,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password,
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                return View();
            }

            else
            {
                return View("Error");
            }
            
        }
    }
}