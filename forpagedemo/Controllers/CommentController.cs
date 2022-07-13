using Comment.ViewModels;
using forpagedemo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjMvcCoreDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace forpagedemo.Controllers
{
    public class CommentController : Controller
    {
        private IWebHostEnvironment _enviroment;
        public CommentController(IWebHostEnvironment p)
        {
            _enviroment = p;
        }

        public IActionResult List(CKeywordViewModel vModel)
        {
            IGOContext db = new IGOContext();
            IEnumerable<FeedbackManagement> datas = null;
            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                datas = from t in db.FeedbackManagements
                        select t;
            }
            else

            {
                datas = db.FeedbackManagements.Where(t => t.Products.ProductName.Contains(vModel.txtKeyword));
            }
            return View(datas.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FeedbackManagement p)
        {
            IGOContext db = new IGOContext();
            db.FeedbackManagements.Add(p);
            //FeedbackManagement prod = db.FeedbackManagements.FirstOrDefault(t => t.FeedbackId == p.FeedbackId);


            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            IGOContext db = new IGOContext();
            FeedbackManagement prod = db.FeedbackManagements.FirstOrDefault(t => t.FeedbackId == id);
            if (prod == null)
                return RedirectToAction("List");
            return View(prod);
        }
        [HttpPost]
        public ActionResult Edit(CProductViewModel p)
        {

            IGOContext db = new IGOContext();
            FeedbackManagement prod = db.FeedbackManagements.FirstOrDefault(t => t.FeedbackId == p.FeedbackId);
            if (prod != null)
            {
                if (p.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    p.photo.CopyTo(new FileStream(
                        _enviroment.WebRootPath + "/images/" + pName, FileMode.Create));
                    //prod.ImagePath = pName;
                }
                //prod.CustomerId = p.CustomerId;
                prod.FeedbackContent = p.FeedbackContent;
                prod.Ranking = p.Ranking;
                //prod.ProductsId = p.ProductsId;
                //prod.FeedbackDate = p.FeedbackDate;
            }
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            IGOContext db = new IGOContext();
            FeedbackManagement prod = db.FeedbackManagements.FirstOrDefault(t => t.FeedbackId == id);
            if (prod != null)
            {
                db.FeedbackManagements.Remove(prod);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
