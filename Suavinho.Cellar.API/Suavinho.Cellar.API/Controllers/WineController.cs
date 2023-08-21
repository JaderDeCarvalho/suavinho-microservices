using Microsoft.AspNetCore.Mvc;
using Suavinho.Cellar.Application.DTO;

namespace Suavinho.Cellar.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        [Route("api/Cellar/{cellarId}/Wine")]
        [HttpGet]
        public IActionResult Get(int cellarId)
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

        [Route("api/Cellar/{cellarId}/Wine/{wineId}")]
        [HttpGet]
        public IActionResult Get(int cellarId, int wineId)
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

        [Route("api/Cellar/{cellarId}/Wine")]
        [HttpPost]
        public IActionResult Post([FromBody] WineDTO wineDto, int cellarId)
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

        [Route("api/Cellar/{cellarId}/Wine/{wineId}")]
        [HttpPut]
        public IActionResult Put([FromBody] WineDTO wineDto, int cellarId, int wineId)
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

        [Route("api/Cellar/{cellarId}/Wine/{wineId}")]
        [HttpDelete]
        public IActionResult Delete(int cellarId, int wineId)
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
