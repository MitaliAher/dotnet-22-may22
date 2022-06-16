using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        EcommerceContext ec;
        public UserController(EcommerceContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<UserDetail> Get()
        {
            return ec.UserDetails;
        }
        [HttpPost]
        public string Post([FromBody] UserDetail user)
        {
            ec.UserDetails.Add(user);
            ec.SaveChanges();
            return "success";
        }

    }
}
