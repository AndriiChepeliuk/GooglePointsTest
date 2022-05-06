using Core.DTO.PointDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GooglePointsTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private readonly IPointService _pointService;

        public PointController(IPointService pointService)
        {
            _pointService = pointService;
        }

        [HttpPost("add")]
        public async Task<ActionResult> CreatePointAsync([FromBody] PointCreationDTO pointCreationDTO)
        {
            await _pointService.AddPoint(pointCreationDTO);
            return Ok();
        }
    }
}
