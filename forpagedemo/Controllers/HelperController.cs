using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCollection.Controllers
{
    public class HelperController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult HelpByAccount()
        {
            return View();
        }
        public IActionResult HelpByAccountDetail()
        {
            return View();
        }

    }
}
