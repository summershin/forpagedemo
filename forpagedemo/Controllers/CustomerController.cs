using forpagedemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCollection.Controllers
{
    public class CustomerController : Controller
    {

        //子慧收藏
        public IActionResult CollectionList()
        {
            return View();
        }


        //鈞傑會員

        // 創建新帳戶
        public IActionResult Registe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registe(Customer c)
        {
            //DemoIgoContext db = new DemoIgoContext();
            //db.TCustomers.Add(c);
            //db.SaveChanges();
            return RedirectToAction("Login", "Home");
        }

        //帳戶管理中心

        public IActionResult List()
        {
            //var datas = from t in (new DemoIgoContext()).TCustomers
            //            select t;
            //List<CCustomerViewModel> list = new List<CCustomerViewModel>();
            //foreach (TCustomer t in datas)
            //{
            //    CCustomerViewModel c = new CCustomerViewModel();
            //    c.customer = t;
            //    list.Add(c);
            //}
            return View(/*list*/);
        }

        public IActionResult UserData()
        {

            return View();
        }


        // 指定會員ID移至資料並修改
        public IActionResult Edit(/*int? id*/)
        {

            //DemoIgoContext db = new DemoIgoContext();
            //TCustomer cust = db.TCustomers.FirstOrDefault(c => c.FCustumerId == id);


            //if (cust == null)
            //{
            //    return RedirectToAction("List");
            //}

            return View();
        }
    }
}
