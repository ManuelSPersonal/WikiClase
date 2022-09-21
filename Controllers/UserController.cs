using Microsoft.AspNetCore.Mvc;
using WikiClase.Models;
using WikiClase.Services;

namespace WikiClase.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok(userService.getAll());
        }

        [HttpPost]
        public dynamic post(User newUser)
        {
            return Ok(userService.register(newUser));
        }
    }
}
