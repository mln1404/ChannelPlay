using ChannelPlay.Services.Interfaces;
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
        private readonly IInformationService _informationService;

        public InformationController(ILogger<InformationController> logger, IInformationService informationService)
        {
            _logger = logger;
            _informationService = informationService;
        }

        [HttpGet(Name = "Informations")]
        public ActionResult<IEnumerable<InformationVM>> Informations()
        {
            try
            {
                return Ok(_informationService.GetAllInformation());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet(Name = "Play")]
        public ActionResult<List<InformationVM>> Play(int id, DateTime? from, DateTime? to)
        {
            try
            {
                return Ok(_informationService.GetChannelInformation(id, from, to));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(Name = "Form")]
        public IActionResult Create(InformationVM information)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Select(x => x.Value?.Errors)
                           .Where(y=>y?.Count>0)
                           .ToList());
                _informationService.CreateInformation(information);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
