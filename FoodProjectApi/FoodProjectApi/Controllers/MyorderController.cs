using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodProjectApi.Models;

namespace FoodProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyorderController : ControllerBase
    {
        fooddbContext db;
        public MyorderController(fooddbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<OrderTbl> GetMyOrders(string username)
        {
            return db.OrderTbls.Where(x => x.UserName == username).ToList();
        }
        [HttpPost]
        public String post([FromBody] Myorder tp)
        {
            db.Myorders.Add(tp);
            db.SaveChanges();
            return "success";
        }
    }
}