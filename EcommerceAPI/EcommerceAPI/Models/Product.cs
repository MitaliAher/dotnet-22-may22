using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            UserProducts = new HashSet<UserProduct>();
        }

        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public virtual ICollection<UserProduct> UserProducts { get; set; }
    }
}
