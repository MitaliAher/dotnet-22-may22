using EStockMarket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStockMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        EStockMarketContext db;
        public RegisterController(EStockMarketContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<ComReg> GetProducts()
        {
            return db.ComRegs;
        }
        [HttpPost]
        public string post([FromBody] ComReg pd)
        {
             
            if (pd.CompanyTurnover > 100000000)
            {
                db.SaveChanges();

            }
            else
                return "Value should be greater than 10cr";
            
            db.ComRegs.Add(pd);
            db.SaveChanges();
            return "Sucess";
        }

    }
}
