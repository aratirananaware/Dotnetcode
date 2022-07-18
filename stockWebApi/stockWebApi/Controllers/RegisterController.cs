using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using stockWebApi.Models;

namespace stockWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        StockDBContext db;
        public RegisterController(StockDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Company> GetProducts()
        {
            return db.Companies;
        }
        [HttpPost]
        public string Post([FromBody] Company company)
        {
            if(company.CompanyTurnover>100000000)
            {
                db.SaveChanges();
            }
            else
            {
                return "value should be greater than 10cr";
            }
            db.Companies.Add(company);
            db.SaveChanges();
            return "success";
        }

        [HttpPut]
        public string Put([FromBody] Company company)
        {
            StockDBContext db = new StockDBContext();
            var tblsampleObj = db.Companies.Where(x => x.CompanyCode == company.CompanyCode);
            if (tblsampleObj != null)
            {
                db.Companies.Update(company);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            StockDBContext db = new StockDBContext();
            var tblsampleObj = db.Companies.Where(x => x.CompanyCode == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Companies.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
