﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIGOfront.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
