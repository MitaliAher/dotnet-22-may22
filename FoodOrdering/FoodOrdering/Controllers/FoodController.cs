﻿using FoodOrdering.Models;
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
            db.FoodDetails.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}
