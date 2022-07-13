using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIGObackend.Controllers
{
    [Area(areaName: "Admin")]
    public class CustomerController : Controller
    {
        //===============>假資料Class<=================================================================================Start
        
        public class Customer
        {
            public int UID { get; set; }
            public string 姓氏 { get; set; }
            public string 名字 { get; set; }
            public string Email { get; set; }
            public string 手機號碼 { get; set; }
            public string 性別 { get; set; }
            public string 居住地區 { get; set; }
            public string 通訊地址 { get; set; }
            public string 生日 { get; set; }
            public string 註冊日期 { get; set; }

            public Customer()
            {
                UID = 0;
                姓氏 = string.Empty;
                名字 = string.Empty;
                Email = string.Empty;
                手機號碼 = string.Empty;
                性別 = string.Empty;
                居住地區 = string.Empty;
                通訊地址 = string.Empty;
                生日 = string.Empty;
                註冊日期 = string.Empty;
            }

            public Customer(int _UID)
            {
                UID = _UID;
                //姓氏 = _姓氏;
                //名字 = _名字;
                //Email = _Email;
                //手機號碼 = _手機號碼;
                //性別 = _性別;
                //居住地區 = _居住地區;
                //通訊地址 = _通訊地址;
                //生日 = _生日;
                //註冊日期 = _註冊日期;
            }

            public override string ToString()
            {
                return $"UID:{UID}";    
            }

        }



        //===============>假資料<============================================================================================
        public IActionResult List()
        {
            DateTime date = DateTime.Now;
            Customer data = new Customer();

            List<Customer> list_ID = new List<Customer>();
            
            list_ID.Add(new Customer(1));
            list_ID.Add(new Customer(2));
            list_ID.Add(new Customer(3));
            list_ID.Add(new Customer(4));
            list_ID.Add(new Customer(5));

            List<Customer> list_LN = new List<Customer>();

            ViewBag.Data = date;
            ViewBag.Customer = date;
            ViewBag.List = list_ID;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
