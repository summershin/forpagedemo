using forpagedemo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace slnMvCore_Igo.ViewModels
{
    public class CCustomerViewModel
    {

        public CCustomerViewModel()
        {
            _cust = new Customer();
        }
        private Customer _cust;
        public Customer customer
        {
            get { return _cust; }
            set { _cust = value; }
        }

        public int FCustumerId
        {
            get { return _cust.CustumerId; }
            set { _cust.CustumerId = value; }
        }

        [DisplayName("密碼")]
        public string FPassword
        {
            get { return _cust.Password; }
            set { _cust.Password = value; }
        }

        [DisplayName("居住城市")]
        public int? FCityId
        {
            get { return _cust.CityId; }
            set { _cust.CityId = value; }
        }

        [DisplayName("通訊地址")]
        public string FAddress
        {
            get { return _cust.Address; }
            set { _cust.Address = value; }
        }

        [DisplayName("姓氏")]
        public string FLastName
        {
            get { return _cust.LastName; }
            set { _cust.LastName = value; }
        }

        [DisplayName("名字")]
        public string FFirstName
        {
            get { return _cust.FirstName; }
            set { _cust.FirstName = value; }
        }

        [DisplayName("電子郵件")]
        public string FEmail
        {
            get { return _cust.Email; }
            set { _cust.Email = value; }
        }

        [DisplayName("手機號碼")]
        public string FPhone
        {
            get { return _cust.Phone; }
            set { _cust.Phone = value; }
        }

        [DisplayName("性別")]
        public string FGender
        {
            get { return _cust.Gender; }
            set { _cust.Gender = value; }
        }


        public IFormFile photo { get; set; }
    }
}
