using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forpagedemo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Food()
        {
            return View();
        }

        public IActionResult Exhibit()
        {
            return View();
        }
    }
}
