using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        sampledbContext db = new sampledbContext();
        [HttpGet]
        public List<Student> Get()
        {
            return db.Students.ToList();
        }
        [HttpGet]
        [Route("StudentsWithCourses")]
        public List<StudentWithCourse> GetStudentsWithCourse()
        {
            return db.Students.Join(db.Courses, x => x.Cid, y => y.Id, (x, y) => new StudentWithCourse { Cname = y.Cname, Name = x.Name, Id = x.Id }).ToList();
        }
        [HttpPost]
        public string Post([FromBody] Student student)
        {
            Student s = new Student();
            s.Id = student.Id;
            s.Name = student.Name;
            s.Cid = student.Cid;
            db.Students.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Student tblsample)
        {
            var tblsampleObj = db.Students.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.Students.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.Students.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Students.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
