using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrdering.ViewModels
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int? PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
