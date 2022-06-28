using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;
using EcommerceApi.ViewModels;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /*
         * EcommerceDBContext db;
        public LoginController(EcommerceDBContext _db)
        {
            db = _db;
        }

        [HttpPost]
        [Route("login")]
        public bool Login(LoginViewModel loginViewModel)
        {
            if (db.TblLogins.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password))
            {
                return true;
            }
            return false;
        }
        [HttpPost]
        [Route("register")]
        public void Register(RegisterViewModel registerViewModel)
        {
            TblLogin tblLogin = new TblLogin();
            tblLogin.UserName = registerViewModel.UserName;
            tblLogin.Password = registerViewModel.Password;
            db.TblLogins.Add(tblLogin);
            db.SaveChanges();
        }
         */
        ProductDBContext db;
        public LoginController(ProductDBContext _db)
        {
            db = _db;
        }
        [HttpPost]
        [Route("login")]
        public bool Login(LoginViewModel loginViewModel)
        {
            if (db.UserDetails.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password))
            {
                return true;
            }
            return false;
        }
        [HttpPost]
        [Route("register")]
        public void Register(RegisterViewModel registerViewModel)
        {
            UserDetail tblLogin = new UserDetail();
            tblLogin.UserName = registerViewModel.UserName;
            tblLogin.Password = registerViewModel.Password;
            db.UserDetails.Add(tblLogin);
            db.SaveChanges();
        }
    }
}
