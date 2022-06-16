using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
    }
}
