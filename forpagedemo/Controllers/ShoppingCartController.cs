using Microsoft.AspNetCore.Mvc;
using prjShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using QRCoder;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mime;
using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace prjShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IWebHostEnvironment environment;
        public ShoppingCartController(IWebHostEnvironment webHostEnvironment)
        {
            environment = webHostEnvironment;
            }

        List<ShoppingCartItem> lists = new List<ShoppingCartItem>
            {
                new ShoppingCartItem(){
                   Name ="世界宗教博物館門票",
                   BuyDay = "2022/03/23",
                   Qty   = 10,
                   Price = 2800

                },

                new ShoppingCartItem(){
                   Name ="遠雄海洋公園門票",
                   BuyDay = "2022/01/23",
                   Qty   = 5,
                   Price = 1200

                },

                new ShoppingCartItem(){
                   Name ="野柳海洋世界",
                   BuyDay = "2022/02/23",
                   Qty   = 2,
                   Price = 160
                 }

            };
        public IActionResult List()
        {
           
            return View(lists);
        }
        public IActionResult Pay()
        {
            return View(lists);
        }
       


        public IActionResult Finish()
        {
           
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode($"{lists[0].Name}:{lists[0].Qty}張", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap icon = new Bitmap(@"wwwroot\ShoppingCartImgs\IGO.jpg");
            Bitmap qrCodeImage = qrCode.GetGraphic(5,Color.Black,Color.White,icon,15,0);

            string outputFileName = @"wwwroot\img\Code.jpg";
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    qrCodeImage.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }






            //----------------------------------------------------------寄信------------------------------------------



            MailMessage em = new MailMessage();
            em.From = new System.Net.Mail.MailAddress("igocompanysender@gmail.com");
            em.To.Add("igocompanysender@gmail.com");
            em.SubjectEncoding = System.Text.Encoding.UTF8;
            em.BodyEncoding = System.Text.Encoding.UTF8;
            em.Subject = "IGO訂單已成立";
            //em.Body = "<html><body><img src='~/ShoppingCartImgs/野柳海洋世界.jpg'></body></html>";
            em.IsBodyHtml = true;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("igocompanysender@gmail.com", "eklktfcbelgblutv");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;

            //------------------------------------------------------夾帶檔案
            var res = new LinkedResource(@"wwwroot\img\Code.jpg", MediaTypeNames.Image.Jpeg);
            res.ContentId = "Pic1";  //每個檔案都需要有一個contentID
                                     
            var htmlBody = "<html><body><h1>訂單已成功</h1>" +
                   $"<p>訂單產品:{lists[0].Name}</p>"+
                  "<img src='cid:Pic1' height:'20px' width:'20px'></body></html>" +
                   "<p> 此為系統主動發送信函，請勿直接回覆此封信件。</p>" ;


            var altView = AlternateView.CreateAlternateViewFromString(
                htmlBody, null, MediaTypeNames.Text.Html);

            altView.LinkedResources.Add(res);
            em.AlternateViews.Add(altView);

            try
            {
                client.Send(em);
            }
            catch
            {

            }
            return View();
        }
    }
}
