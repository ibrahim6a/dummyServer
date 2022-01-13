using Microsoft.AspNetCore.Mvc;


namespace dummy_server.Controllers {

    [ApiController]
    [Route("[Controller]")]
    public class RegisterUser : ControllerBase {

        [HttpPost]
        public IActionResult Register() {
            return Ok();
        }

    }

}