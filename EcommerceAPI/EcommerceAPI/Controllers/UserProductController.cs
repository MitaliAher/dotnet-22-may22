using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProductController : ControllerBase
    {

        EcommerceContext ec;
        public UserProductController(EcommerceContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<UserProduct> Get()
        {
            return ec.UserProducts;
        }
        [HttpPost]
        public string Post([FromBody] UserProduct uproduct)
        {
            ec.UserProducts.Add(uproduct);
            ec.SaveChanges();
            return "success";
        }
    }
}

