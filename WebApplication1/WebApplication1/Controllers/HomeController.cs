using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<SampleTable> Get()
        {
            Demo1Context dd = new Demo1Context();
            return dd.SampleTables.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            Demo1Context dd = new Demo1Context();
            SampleTable ss = new SampleTable();
            ss.Fname = sample;
            dd.SampleTables.Add(ss);
            dd.SaveChanges();
            return "Success";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            Demo1Context dd = new Demo1Context();
            var sampletableobj = dd.SampleTables.Where(x => x.Id == Id).FirstOrDefault();
            if (sampletableobj != null)
            {
                dd.SampleTables.Remove(sampletableobj);
                dd.SaveChanges();

                return "Success";
            }
            //SampleTable ss = new SampleTable();
            //ss.Id = sample;
            //dd.SampleTables.Remove(ss);
            return "Fail";
        }

        [HttpPut]
        public string Put([FromBody] SampleTable sampletable)
        {
            Demo1Context dd = new Demo1Context();
            var sampletableobj = dd.SampleTables.Where(x => x.Id == sampletable.Id);
            if (sampletableobj != null)
            {
                dd.SampleTables.Update(sampletable);
                dd.SaveChanges();
                return "Success";

            }
            //SampleTable ss = new SampleTable();
            //ss.Id = sample;
            //dd.SampleTables.U(ss);
            return "Fail";
        }

    }


    //public List<Employee> Get()
    //{
    //    Demo1Context dd = new Demo1Context();
    //    return dd.Employees.ToList();

    //}

    //public string Post([FromBody] string sample)
    //{
    //    Demo1Context dd = new Demo1Context();
    //    Employee ee = new Employee();
    //    ee.Fname = sample;
    //    dd.Employees.Add(ee);
    //    dd.SaveChanges();
    //    return "Success";
    //}

}

