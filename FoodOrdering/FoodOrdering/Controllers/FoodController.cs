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
    public class FoodController : ControllerBase
    {

        FoodProjectContext db;
        public FoodController(FoodProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<FoodDetail> GetCategory()
        {
            return db.FoodDetails;
        }
        [HttpPost]
        public string post([FromBody] FoodDetail ct)
        {
            // db.FoodDetails.Add(ct);
            //db.SaveChanges();
            if (ct.IsActive == 1)
            {
                db.SaveChanges();
            }
            else 
                return "no";

            db.FoodDetails.Add(ct);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] FoodDetail tblsample)
        {
            var tblsampleObj = db.FoodDetails.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.FoodDetails.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}

