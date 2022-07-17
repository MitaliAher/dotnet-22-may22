using System;
using System.Collections.Generic;

#nullable disable

namespace FoodOrdering.Models
{
    public partial class FoodDetail
    {
        public int Id { get; set; }
        public int? CatId { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public int? FoodPrice { get; set; }
        public string FoodImage { get; set; }
    }
}
