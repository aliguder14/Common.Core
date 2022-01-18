using Common.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAngular.GenerateTCKN.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonelController : ControllerBase
    {

        private readonly ILogger<PersonelController> _logger;

        
        public PersonelController(ILogger<PersonelController> logger)
        {
            _logger = logger;

        }


        [HttpPost("tc")]
        public IActionResult GetTC()
        {
            return Ok(GenerationIslemleri.GenerateTCKN());
        }
    }
}
