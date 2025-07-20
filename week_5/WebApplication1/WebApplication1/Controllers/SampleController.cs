using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        [Authorize]
        [HttpGet("secure")]
        public IActionResult GetSecureData()
        {
            return Ok("This is a protected endpoint!");
        }

        [AllowAnonymous]
        [HttpGet("public")]
        public IActionResult GetPublicData()
        {
            return Ok("This is a public endpoint.");
        }
    }
}
