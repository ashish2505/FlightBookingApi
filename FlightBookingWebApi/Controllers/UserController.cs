using FlightBookingWebApi.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FlightBookingWebApi.Controllers
{
    
    public class UserController : ControllerBase
    {
        private readonly IUserService _iUserService;

        public UserController(IUserService iuserService)
        {
            _iUserService = iuserService;
        }

    //[HttpGet]
        
        //public bool IsValidUser()
        //{
        //    return true;
        //}

        //[HttpPost]
        //public bool IsValidUser1()
        //{
        //    return true;
        //}

        //USer Controller
        [HttpGet]
        [Route("api/User")]
        public string IsValidUser(string userName, string password)
        {
            //var IsValid=_iUserService.IsValidUser(userName, password);
            //if (IsValid == true)
            //{
            //    return Ok();
            //}
            //else
            //    return NotFound("Not Found");
           return  _iUserService.IsValidUser(userName, password);
        }
    }
}
