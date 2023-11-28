using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace boat_webapi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosido = DateTime.Now.ToShortTimeString();
            //return BadRequest("Nem jó a bemenő adat");

            return Ok(pontosido.ToUpper());
        }
    }
}
