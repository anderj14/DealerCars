using AutoMapper;
using DealerCarsApp.Dto;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using DealerCarsApp.Repository;
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
    }
}
