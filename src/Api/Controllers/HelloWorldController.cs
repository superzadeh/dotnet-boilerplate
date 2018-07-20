using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger) {
      this._logger = logger;
    }

        // GET: /<controller>/
        [HttpGet]
        public ActionResult<string> Get()
        {
            this._logger.LogDebug("Some debug trace here");
            return Ok("Hello World");
        }
    }
}
