using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using forpagedemo.Models;

namespace prjMvcCoreDemo.ViewModels
{
    public class CProductViewModel
    {
        public CProductViewModel()
        {
            _prod = new FeedbackManagement();
        }
        private FeedbackManagement _prod;
        public FeedbackManagement product
        {
            get { return _prod; }
            set { _prod = value; }
        }
        public int FeedbackId
        {
            get { return _prod.FeedbackId; }
            set { _prod.FeedbackId = value; }
        }
        [DisplayName("客戶id")]
        public int? CustomerId
        {
            get { return _prod.CustomerId; }
            set { _prod.CustomerId = value; }
        }
        [DisplayName("評論")]
        public string FeedbackContent
        {
            get { return _prod.FeedbackContent; }
            set { _prod.FeedbackContent = value; }
        }
        [DisplayName("分數")]
        public int? Ranking
        {
            get { return _prod.Ranking; }
            set { _prod.Ranking = value; }
        }
        [DisplayName("產品id")]
        public int? ProductsId
        {
            get { return _prod.ProductsId; }
            set { _prod.ProductsId = value; }
        }
        [DisplayName("日期")]
        public DateTime? FeedbackDate
        {
            get { return _prod.FeedbackDate; }
            set { _prod.FeedbackDate = value; }

        }
        public string ImagePath
        {
            get { return _prod.ImagePath; }
            set { _prod.ImagePath = value; }
        }
        public IFormFile photo { get; set; }
    }
}
