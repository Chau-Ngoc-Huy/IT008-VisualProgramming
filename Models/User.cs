using System;
using System.Collections.Generic;

#nullable disable

namespace GoninDigital.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Favorites = new HashSet<Favorite>();
            Invoices = new HashSet<Invoice>();
            Purchaseds = new HashSet<Purchased>();
            Vendors = new HashSet<Vendor>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int TypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual UserType Type { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Purchased> Purchaseds { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
