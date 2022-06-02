using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSoma.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("{n1}/{n2}")]
        public IActionResult Soma(int n1, int n2)
        {
            var resultado = n1 + n2;          

            return Ok(resultado);
        }
    }
}
