using System;
using System.Collections.Generic;

#nullable disable

namespace FoodOrdering.Models
{
    public partial class OrderTbl
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PaymentMode { get; set; }
        public string Address { get; set; }
    }
}
