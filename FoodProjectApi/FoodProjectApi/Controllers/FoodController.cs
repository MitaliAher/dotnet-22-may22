using FoodProjectApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        FoodProjectContext db;
        public FoodController(FoodProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<FoodDetail> GetFoodDetails()
        {
            return db.FoodDetails;
        }
        [HttpPost]
        public string post([FromBody] FoodDetail pd)
        {
            db.FoodDetails.Add(pd);
            db.SaveChanges();
            return "Sucess";
        }
    }
}

