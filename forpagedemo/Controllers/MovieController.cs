using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forpagedemo.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
