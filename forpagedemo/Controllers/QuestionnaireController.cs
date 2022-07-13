using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCollection.Controllers
{
    public class QuestionnaireController : Controller
    {
        public IActionResult Question()
        {
            return View();
        }

        public IActionResult QuestionResult()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult TestResult()
        {
            return View();
        }

       

       

    }
}
