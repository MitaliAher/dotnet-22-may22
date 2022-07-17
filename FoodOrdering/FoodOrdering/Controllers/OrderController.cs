using FoodOrdering.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrdering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        FoodProjectContext db;
        public OrderController(FoodProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<OrderTbl> GetCategory()
        {
            return db.OrderTbls;
        }
        [HttpPost]
        public string post([FromBody] OrderTbl ct)
        {
            db.OrderTbls.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}

