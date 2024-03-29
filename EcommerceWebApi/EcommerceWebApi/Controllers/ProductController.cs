﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApi.Models;

namespace EcommerceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceDBContext db;
        public ProductController(EcommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblProduct> GetProducts()
        {
            return db.TblProducts;
        }
        [HttpPost]
        public string Post([FromBody] TblProduct product)
        {
            db.TblProducts.Add(product);
            db.SaveChanges();
            return "success";
        }
    }
}
