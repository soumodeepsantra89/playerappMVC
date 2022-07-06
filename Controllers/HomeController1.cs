using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            List<player> listplayers = new List<player>
            {
                new player { id = 1, name ="Virat", average =56.23},
                new player { id = 2, name ="Dhoni",average =33.60},
                new player{ id = 3, name ="Rohit",average=55.22}
            };
            return View(listplayers);
        }
    }
}
