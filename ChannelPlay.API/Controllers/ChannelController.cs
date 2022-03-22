using ChannelPlay.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChannelPlay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        private readonly ILogger<ChannelController> _logger;

        public ChannelController(ILogger<ChannelController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Form")]
        public async Task<IActionResult> Create(TblChannel channel)
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


        [HttpPost(Name = "Assign")]
        public async Task<IActionResult> Assign(TblChannel channel, int[] newInformation)
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
