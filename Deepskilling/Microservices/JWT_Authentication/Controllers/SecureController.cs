using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecureData()
        {
            return Ok(new
            {
                Message = "You are authenticated!",
                Data = "This is protected data."
            });
        }
    }
}