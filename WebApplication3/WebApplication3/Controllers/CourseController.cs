using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        sampledbContext db = new sampledbContext();
        [HttpGet]
        public List<Course> Get()
        {
            return db.Courses.ToList();
        }
        [HttpPost]
        public string Post([FromBody] int id,string coursename)
        {
            Course s = new Course();
            s.Id = id;
            s.Cname = coursename;
            db.Courses.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Course tblsample)
        {
            var tblsampleObj = db.Courses.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.Courses.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.Courses.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Courses.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
