using ImageProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        sampleContext db;
        public ImageController(sampleContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IEnumerable<ImageTbl> GetImages()
        {
            return db.ImageTbls;
        }
        [HttpPost]
        public string post([FromBody] ImageTbl pd)
        {
            db.ImageTbls.Add(pd);
            db.SaveChanges();
            return "Sucess";
        }
    }
}
