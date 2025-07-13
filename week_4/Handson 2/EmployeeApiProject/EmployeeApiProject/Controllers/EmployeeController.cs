using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var employees = new List<string> { "Ashutosh", "Ravi", "Simran" };
            return Ok(employees);
        }
    }
}
