using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forpagedemo.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class DiscountController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
