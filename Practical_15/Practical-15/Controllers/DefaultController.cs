using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> _log;

        public DefaultController(ILogger<DefaultController> log)
        {
            _log = log;
        }

        [HttpGet]
        public IEnumerable<string> get()
        {
            _log.LogInformation("Get Method Of Default Controller Called");
            _log.LogWarning("Warning Message in Get Method");
           
            return new string[] {  "Hello World" };
        }
    }
}
