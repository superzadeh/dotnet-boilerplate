using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopOnContainers.Services.Ordering.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello world");
        }
    }
}