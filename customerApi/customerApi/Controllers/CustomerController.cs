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
    public class CustomerController : ControllerBase
    {
        CustomerDB1Context db;
        public CustomerController(CustomerDB1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return db.Customers;
        }
        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            
            db.Customers.Add(customer);
            db.SaveChanges();
            return "Success";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.Customers.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Customers.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

    }
}
