using ChannelPlay.Entities.Entities;
using ChannelPlay.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChannelPlay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        private readonly ILogger<ChannelController> _logger;
        private readonly IChannelService _channelService;

        public ChannelController(ILogger<ChannelController> logger, IChannelService channelService)
        {
            _logger = logger;
            _channelService = channelService;
        }

        [HttpPost(Name = "Form")]
        public IActionResult Create(TblChannel channel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Select(x => x.Value?.Errors)
                           .Where(y=>y?.Count>0)
                           .ToList());
                _channelService.CreateChannel(channel);
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
                _channelService.AssignInformation(channel, newInformation);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
