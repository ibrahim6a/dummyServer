using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using dummy_server.Models;
using dummy_server.Data;
using Microsoft.AspNetCore.Cors;

namespace dummy_server.Controllers {
    
    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase {

        [HttpPost]
        public User Login([FromBody]LoginModel loginModel) {
            
            Console.WriteLine(loginModel.Email);
            Console.WriteLine(loginModel.Password);
            DummyData dummyData = new DummyData();
            return dummyData.userList[0];

        }

    }
}