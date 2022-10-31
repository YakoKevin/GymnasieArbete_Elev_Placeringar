using GymnasieArbetePlaceringarAPI.IServices.IElevServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymnasieArbetePlaceringarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevController : ControllerBase
    {
        public IGetElevObjectService _getElevObjectService { get; set; }
        public ElevController(IGetElevObjectService getElevObjectService)
        {
            _getElevObjectService = getElevObjectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetElever()
        {
            var test = _getElevObjectService.GetEleverAsObjects();
            return Ok(test);
        }

    }
}
