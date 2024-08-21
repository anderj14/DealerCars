using AutoMapper;
using DealerCarsApp.CreateDto;
using DealerCarsApp.Dto;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace DealerCarsApp.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class TrimController : Controller
    {
        private readonly ITrimRepository _trimRepository;
        private readonly IMapper _mapper;

        public TrimController(ITrimRepository trimRepository, IMapper mapper)
        {
            _trimRepository = trimRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Trim>))]
        public IActionResult GetTrims()
        {
            var types = _mapper.Map<List<TrimDto>>(_trimRepository.GetTrims());

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(types);
        }

        [HttpGet("{trimId}")]
        [ProducesResponseType(200, Type = typeof(Trim))]
        public IActionResult GetTrim(int trimId)
        {
            if (!_trimRepository.GetTrimExists(trimId)) return NotFound();
            var type = _mapper.Map<TrimDto>(_trimRepository.GetTrim(trimId));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(type);
        }

        [HttpPost]
        public ActionResult CreateTrim([FromBody] CreateTrimDto createTrimDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var trim = _mapper.Map<Trim>(createTrimDto);

            try
            {
                _trimRepository.CreateTrim(trim);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var trimDto = _mapper.Map<TrimDto>(trim);
            return Ok(trimDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTrim(int id, CreateTrimDto updateTrimDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_trimRepository.GetTrimExists(id))
                return NotFound();

            var updateTrim = _mapper.Map<Trim>(updateTrimDto);
            updateTrim.Id = id;

            try
            {
                _trimRepository.UpdateTrim(updateTrim);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var trimDto = _mapper.Map<TrimDto>(updateTrim);

            return Ok(trimDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTrim(int id)
        {
            if (!_trimRepository.GetTrimExists(id))
                return NotFound();

            var trim = _trimRepository.GetTrim(id);

            try
            {
                _trimRepository.DeleteTrim(trim);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
