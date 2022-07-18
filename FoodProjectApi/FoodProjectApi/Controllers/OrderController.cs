/*
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
    public class OrderController : ControllerBase
    {
        FoodProjectContext db;
        public OrderController(FoodProjectContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<OrderTbl> GetFoods()
        {
            return db.OrderTbls;
        }
        [HttpPost]
        public string Post([FromBody] OrderTbl food)
        {
            db.OrderTbls.Add(food);
            db.SaveChanges();
            return "success";
        }
    }
}
*/