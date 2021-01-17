using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace JobSeeker.Controllers
{
    public class AccountManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RegisterFizickoLice()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RegisterPoslodavac()
        {
            return View();
        }

    }
}
