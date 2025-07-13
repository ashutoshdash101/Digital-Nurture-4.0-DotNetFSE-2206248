using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string> { "Value1", "Value2" };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string newValue)
        {
            values.Add(newValue);
            return Ok($"Added: {newValue}");
        }
    }
}
