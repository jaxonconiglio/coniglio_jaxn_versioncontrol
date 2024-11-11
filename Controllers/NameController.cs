using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/name")]
    [ApiController]

    public class NameController ; Controller
    {

        [HttpGet]

        public IActionResult GetName()
        {

            var result = new { Name = "Jaxon" };
            return Ok(result);
        }
    }
}