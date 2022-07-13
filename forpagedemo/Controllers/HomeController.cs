using forpagedemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prjIGOfront.Models;
using prjIGOfront.ViewModels;
using prjMvcCoreDemo.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace forpagedemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            //string viewRecord = "";
            //List<ViewItems> list = null;
            //if (!HttpContext.Session.Keys.Contains(CDictionary.SK_瀏覽過的_商品們_列表))
            //{
            //    list = new List<ViewItems>();
            //}
            //else
            //{
            //    viewRecord = HttpContext.Session.GetString(CDictionary.SK_瀏覽過的_商品們_列表);
            //    list = JsonSerializer.Deserialize<List<ViewItems>>(viewRecord);
            //}
            //ViewItems items = new ViewItems()
            //{
            //    productName = "台北喜來登大飯店｜十二廚",
            //    productPhotoPath = "~/img/Home_HotSales_03.jpg"

            //};
            return View();
        }


        public IActionResult City()
        {
            return View();

        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vModel)
        {
            //TCustomer cust = (new DemoIgoContext()).TCustomers.FirstOrDefault(c => c.FPhone.Equals
            //(vModel.txtAccount));
            //if (cust != null)
            //{
            //    if (cust.FPassword.Equals(vModel.txtPassword))
            //    {
            //        string jsonUser = JsonSerializer.Serialize(cust.FCustumerId);
            //        HttpContext.Session.SetString(
            //            CDictionary.SK_LOGINED_USER , jsonUser);


            //        return RedirectToAction("index", "Home");
            //    }
            //}
            return RedirectToAction("Home", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
