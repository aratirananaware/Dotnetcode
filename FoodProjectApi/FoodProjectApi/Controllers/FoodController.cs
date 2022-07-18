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
    public class FoodController : ControllerBase
    {
        fooddbContext db;
        public FoodController(fooddbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<FoodDetail> GetFoods()
        {
            return db.FoodDetails;
        }
        [HttpPost]
        public string Post([FromBody] FoodDetail food)
        {
            if (food.IsActive == 1)
            {
                db.SaveChanges();
            }
            else
                return "not available";
            db.FoodDetails.Add(food);
            db.SaveChanges();
            return "success";
        }
    }
}
