using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Alex_Azure_Test_API.Controllers
{
    [Route("api/[controller]/[action]/{val1?}/{val2?}")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public IActionResult Add(double val1, double val2)
        {
            return Ok(val1 + val2);
        }

        [HttpGet]
        public IActionResult Subtract(double val1, double val2)
        {
            return Ok(val1 - val2);
        }

        [HttpGet]
        public IActionResult Multiply(double val1, double val2)
        {
            return Ok(val1 * val2);
        }

        [HttpGet]
        public IActionResult Divide(double val1, double val2)
        {
            if (val2 == 0)
            {
                return BadRequest("Cannot divide by zero");
            }

            return Ok(val1 / val2);
        }
    }
}
