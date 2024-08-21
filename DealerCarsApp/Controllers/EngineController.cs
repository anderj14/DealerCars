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
    public class EngineController : Controller
    {
        private readonly IEngineRepository _engineRepository;
        private readonly IMapper _mapper;

        public EngineController(IEngineRepository engineRepository, IMapper mapper)
        {
            _engineRepository = engineRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Engine>))]
        public IActionResult GetEngines()
        {
            var engines = _mapper.Map<List<EngineDto>>(_engineRepository.GetEngines());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(engines);
        }

        [HttpGet("{engineId}")]
        [ProducesResponseType(200, Type = typeof(Engine))]
        [ProducesResponseType(400)]
        public IActionResult GetEngine(int engineId)
        {
            if (!_engineRepository.EngineExists(engineId)) return NotFound();

            var engine = _mapper.Map<EngineDto>(_engineRepository.GetEngine(engineId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(engine);
        }


        [HttpPost]
        public ActionResult CreateEngine([FromBody] CreateEngineDto createEngineDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var engine = _mapper.Map<Engine>(createEngineDto);

            try
            {
                _engineRepository.CreateEngine(engine);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var EngineDto = _mapper.Map<EngineDto>(engine);
            return Ok(EngineDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEngine(int id, CreateEngineDto updateEngineDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_engineRepository.EngineExists(id))
                return NotFound();

            var updateEngine = _mapper.Map<Engine>(updateEngineDto);
            updateEngine.Id = id;

            try
            {
                _engineRepository.UpdateEngine(updateEngine);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var EngineDto = _mapper.Map<EngineDto>(updateEngine);

            return Ok(EngineDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEngine(int id)
        {
            if (!_engineRepository.EngineExists(id))
                return NotFound();

            var engine = _engineRepository.GetEngine(id);

            try
            {
                _engineRepository.DeleteEngine(engine);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
