m  using ChannelPlay.Entities.Entities;
using ChannelPlay.Services.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChannelPlay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly ILogger<InformationController> _logger;

        public InformationController(ILogger<InformationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Informations")]
        public async Task<ActionResult<List<InformationVM>>> Informations()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet(Name = "Play")]
        public async Task<ActionResult<List<InformationVM>>> Play(int number, DateTime? from, DateTime? to)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(Name = "Form")]
        public async Task<IActionResult> Create(InformationVM information)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
