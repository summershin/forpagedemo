using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forpagedemo.Controllers
{
    public class DiscountController : Controller
    {
        public IActionResult ShowView()
        {
            return View();
        }
    }
}
