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
    public class CategoryController : ControllerBase
    {
        FoodProjectContext db;
        public CategoryController(FoodProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Category> GetCategory()
        {
            return db.Categories;
        }
        [HttpPost]
        public string post([FromBody] Category pd)
        {
            db.Categories.Add(pd);
            db.SaveChanges();
            return "Sucess";
        }
    }
}

