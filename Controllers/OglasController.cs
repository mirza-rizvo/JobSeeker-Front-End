using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeeker.Controllers
{
    public class OglasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Create()
        {
            return View();
        }
        public ViewResult Edit()
        {
            return View();
        }
        public ViewResult Details()
        {
            return View();
        }
    }
}
