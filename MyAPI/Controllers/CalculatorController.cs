using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("{one}/{two}")]
        public string Add2Numbers(int one, int two)
        {
            return $"The sum of {one} and {two} is {one + two}.";
        }
    }
}
