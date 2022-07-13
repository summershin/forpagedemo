using forpagedemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace forpagedemo.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
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
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult CancelOrder()
        {
            return View();
        }
        public IActionResult SentCancelOrderEmail()
        {
            MailMessage mail = new MailMessage();
            // 發信來源,最好與你發送信箱相同,否則容易被其他的信箱判定為垃圾郵件.
            mail.From = new MailAddress("igocompanysender@gmail.com");
            // 收件人 Email 地址
            mail.To.Add("igocompanysender@gmail.com");
            // 主旨
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.Subject = "【顧客取消訂單】IGO ticket shop";
            // 內文
            //mail.Body = body;
            mail.Body = "<html><body>" +
            "<h1 style='color:lightsalmon;background-color:black'>IGO</h1>" +
            "<hr>" +
            "<h4>【顧客取消訂單】</h4>" +
            "<h5>顧客: 戴樂古 先生/小姐</h5>" +
            "<h5>取消訂單編號:236</h5>" +
            "<h5>訂單狀態: 取消訂單</h5>" +
            "<h5>退款狀態: 申請退款中</h5>" +
            "<h5>產品名稱: 新竹芙洛麗大飯店FLEURLIS |食譜自助百匯</h5>" +
            "<h5>數量: 1張</h5>" +
            "<h5>票種: 下午茶</h5>" +
            "<h5>金額: $911</h5>" +
            "<br>" +
            "<h4 style='color:white;background-color:gray'>IGO 版權所有©Copyright 2022 All Rights Reserved</h4>" +
            "</body></html>";

            // 內文是否為 HTML
            mail.IsBodyHtml = true;
            // 優先權
            mail.Priority = MailPriority.Normal;

            System.Net.Mail.SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("igocompanysender@gmail.com", "eklktfcbelgblutv");

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;


            //附帶檔案方法1:
            //Attachment attachment = new Attachment(@"\wwwroot\txtfile\newsletter.jpg");//<-這是附件部分~先用附件的物件把路徑指定進去~
            //attachment.ContentId = "Pic1";
            //attachment.ContentDisposition.Inline = true;
            //mail.Attachments.Add(attachment);
            //var htmlBody = "<img src=cid:Pic1/>";
            ////mail.Attachments.Add(attachment);




            //附帶檔案方法2:
            //var attachment = new LinkedResource(@"wwwroot\txtfile\newsletter.jpg", MediaTypeNames.Image.Jpeg);//<-這是附件部分~先用附件的物件把路徑指定進去~

            //attachment.ContentId = "Pic1";
            ////attachment.ContentDisposition.Inline = True;

            //var htmlBody = "<html><body><img src='cid:Pic1'/></body></html>";
            //var altView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);

            //altView.LinkedResources.Add(attachment);

            //mail.AlternateViews.Add(altView);

            try
            {
                // 寄送出去
                client.Send(mail);


            }
            catch
            {

            }
            client.Dispose();
            return View();

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
        public IActionResult Analytics()
        {
            return View();
        }
    }
}
