using Microsoft.AspNetCore.Mvc;
using Suavinho.Cellar.Application.Contracts.Inbound;
using Suavinho.Cellar.Application.DTO;

namespace Suavinho.Cellar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CellarController : ControllerBase
    {
        private ICellarService _cellarService { get; }

        public CellarController(ICellarService cellarService)
        {
            _cellarService = cellarService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var cellarDtos = _cellarService.GetAll();
                return Ok(cellarDtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var cellarDto = _cellarService.GetCellar(id);

                Parallel.ForEach(cellarDto.Wines, wine =>
                {
                    wine.Cellars = new List<CellarDTO>();
                });

                return Ok(cellarDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CellarDTO cellarDto)
        {
            try
            {
                _cellarService.CreateCellar(cellarDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CellarDTO cellarDto)
        {
            try
            {
                _cellarService.UpdateCellar(cellarDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _cellarService.DeleteCellar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
