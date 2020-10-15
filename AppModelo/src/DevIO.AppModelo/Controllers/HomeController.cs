using System;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.AppModelo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
