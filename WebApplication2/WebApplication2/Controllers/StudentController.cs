using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Demo2Context db = new Demo2Context();
        [HttpGet]
        public List<StudentInfo> Get()
        {
            return db.StudentInfos.ToList();
        }
        [HttpGet]
        [Route("StudentsWithCourses")]
        public List<StudentWithCourse> GetStudentsWithCourse()
        {
            return db.StudentInfos.Join(db.StudentInfos, x => x.CouseId, y => y.Id, (x, y) => new StudentWithCourse { CourseName=y.courseName, FirstName = x.FirstName, LastName = x.Lastname, Gender = x.Gender, Id = x.Id }).ToList();
        }
        [HttpPost]
        public string Post([FromBody] StudentInfo student)
        {
            StudentInfo s = new StudentInfo();
            s.FirstName = student.FirstName;
            s.Lastname = student.Lastname;
            s.CouseId = student.CouseId;
            s.Gender = student.Gender;
            db.StudentInfos.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] StudentInfo tblsample)
        {
            var tblsampleObj = db.StudentInfos.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.StudentInfos.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.StudentInfos.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.StudentInfos.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}

