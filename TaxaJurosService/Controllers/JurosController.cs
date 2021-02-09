using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaJurosService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosController : ControllerBase
    {
        private readonly ILogger<JurosController> _logger;

        public JurosController(ILogger<JurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get()
        {
            return 0.01;
           
        }
    }
}
