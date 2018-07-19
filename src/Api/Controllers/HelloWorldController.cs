using Microsoft.AspNetCore.Mvc;

namespace Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello Yolo");
        }
    }
}