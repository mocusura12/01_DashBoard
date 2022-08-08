using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_DashBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01_DashBoard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Student([Bind("Name", "Age")] Student model)
        {
            return View();
        }
    }
}
