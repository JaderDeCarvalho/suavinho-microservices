using Microsoft.AspNetCore.Mvc;
using Suavinho.Cellar.Applicarion.Contracts.Inbound;
using Suavinho.Cellar.Applicarion.Services;
using Suavinho.Cellar.Application.DTO;

namespace Suavinho.Cellar.API.Controllers
{

    [ApiController]
    public class WineController : ControllerBase
    {
        private IWineService _wineService { get; }

        public WineController(IWineService wineService)
        {
            _wineService = wineService;
        }

        [Route("api/Cellar/{cellarId}/Wine")]
        [HttpGet]
        public IActionResult Get(int cellarId)
        {
            try
            {
                var wineDtos = _wineService.GetAll(cellarId);
                return Ok(wineDtos);
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
                var wineDtos = _wineService.GetWine(cellarId, wineId);

                Parallel.ForEach(wineDtos.Cellars, cellar =>
                {
                    cellar.Wines = new List<WineDTO>();
                });

                return Ok(wineDtos);
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
                _wineService.CreateWine(wineDto, cellarId);
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
                _wineService.UpdateWine(wineDto,cellarId,wineId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("api/Cellar/{cellarId}/Wine/{wineId}")]
        [HttpDelete]
        public IActionResult Delete([FromBody] bool isDeleteAll, int cellarId, int wineId)
        {
            try
            {
                _wineService.DeleteCellar(isDeleteAll,cellarId,wineId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
