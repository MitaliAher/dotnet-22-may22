using customerApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        CustomerDB1Context db;
        public SupplierController(CustomerDB1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            return db.Suppliers;
        }
        [HttpPost]
        public string Post([FromBody] Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return "Success";
        }

    }
}
