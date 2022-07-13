using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjIGOfront.Models;
using prjIGOfront.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjIGOfront.Controllers
{
    public class HomeApiController : Controller
    {
        public IActionResult showViewProductCountBySession()
        {
            int viewCount = 0;

            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_瀏覽過的_次數))
            {
                viewCount++;
            }
            else 
            {
                viewCount =(int)HttpContext.Session.GetInt32(CDictionary.SK_瀏覽過的_次數);
                viewCount++;
            }
            HttpContext.Session.SetInt32(CDictionary.SK_瀏覽過的_次數, viewCount);
            
            return Content(viewCount.ToString());
        }
        public IActionResult showViewNoProductCountBySession()
        {
            int viewCount = 0;

            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_瀏覽過的_次數))
            {
                viewCount = 0;
            }
            else
            {
                viewCount = (int)HttpContext.Session.GetInt32(CDictionary.SK_瀏覽過的_次數);
            }
            HttpContext.Session.SetInt32(CDictionary.SK_瀏覽過的_次數, viewCount);

            return Content(viewCount.ToString());
        }
        public IActionResult showViewProductContentBySession() 
        {
            string jsonView = "";
            List<ViewItems> list = null;

            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_瀏覽過的_商品們_列表))
            {
                list = new List<ViewItems>();
            }
            else 
            {
                jsonView = HttpContext.Session.GetString(CDictionary.SK_瀏覽過的_商品們_列表);
                list = JsonSerializer.Deserialize<List<ViewItems>>(jsonView); //將字串轉為json

            }
            ViewItems item = new ViewItems()
            {
                productName = "普立茲新聞攝影獎80週年展",
                productPhotoPath = "Home_carousel_01.jpg"

            };
            list.Add(item);
            jsonView = JsonSerializer.Serialize(list); //json轉為字串
            HttpContext.Session.SetString(CDictionary.SK_瀏覽過的_商品們_列表, jsonView);

            return Content(item.productName);
            //return Json(jsonView);
        }
    }
}



