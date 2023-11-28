using boat_webapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace boat_webapi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]

        public IActionResult questionAll()
        {
            HajosContext context = new HajosContext();
            var kerdesek = from x in context.Questions
                           select x.Question1;

            return Ok(kerdesek);
        }
    }
}
