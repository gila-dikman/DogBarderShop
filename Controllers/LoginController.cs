using Microsoft.AspNetCore.Mvc;
using DogBarderShopWebApp.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogBarderShopWebApp.Models;

namespace DogBarderShopWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public User CheckLogin(string userName, string password)
        {
            return new LoginServies().CheckLogin(userName, password);
        }

        public User CreateUser(string firstName, string userName, string password)
        {
            return new LoginServies().CreateUser(firstName, userName, password);
        }
    }
}
