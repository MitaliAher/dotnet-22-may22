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
        public string post([FromBody] Category ct)
        {
            db.Categories.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}

