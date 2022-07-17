using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class UserProduct
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }

        public virtual Product Order { get; set; }
    }
}
