using Microsoft.AspNetCore.Mvc;
using prjIGObackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIGObackend.Controllers
{
    [Area(areaName: "Admin")]
    public class SupplierController : Controller
    {
        List<CSupplier> suppliers = new List<CSupplier>();
        private int _nextId = 1;


        public IActionResult Create(  )
        {
            

            return View( );
        }

        [HttpPost]
        public IActionResult Create(CSupplier C)
        {

            if (C == null)
            {
                throw new ArgumentNullException("item");
            }
            CSupplier item = new CSupplier
            {
                SupplierID = C.SupplierID,
                CompanyName =C.CompanyName,
                Phone = C.Phone,
                Address = C.Address
                

            };

            suppliers.Add(item);
             
            return RedirectToAction("List");
        }




            public IActionResult List()
        {


            CSupplier item = new CSupplier()
            {
                CompanyName = "六福村",
                Phone = "03-545665",
                Address = "新竹縣關西鎮60號"
            };
            suppliers.Add(item);
            CSupplier item1 = new CSupplier()
            {
                CompanyName = "台中麗寶樂園",
                Phone = "04-25582459",
                Address = "台中市后里區福容路8號",
            };
            suppliers.Add(item1);

            return View(suppliers);
        }


        public IActionResult Delete()
        {


            return View();
        }


        public IActionResult Edit()
        {


            return View();
        }




    }
}
