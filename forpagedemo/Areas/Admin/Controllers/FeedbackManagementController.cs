using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIGObackend.Controllers
{
    [Area(areaName: "Admin")]
    public class FeedbackManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       

    }
}
