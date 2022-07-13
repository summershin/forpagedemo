using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Collections = new HashSet<Collection>();
            FeedbackManagements = new HashSet<FeedbackManagement>();
            Orders = new HashSet<Order>();
            Temps = new HashSet<Temp>();
        }

        public int CustumerId { get; set; }
        public string Password { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime? Birth { get; set; }
        public DateTime? SignUpDate { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }
        public virtual ICollection<FeedbackManagement> FeedbackManagements { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Temp> Temps { get; set; }
    }
}
