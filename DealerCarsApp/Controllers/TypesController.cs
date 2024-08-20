using AutoMapper;
using DealerCarsApp.Dto;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace DealerCarsApp.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class TypesController : Controller
    {
        private readonly ITrimRepository _trimRepository;
        private readonly IMapper _mapper;

        public TypesController(ITrimRepository trimRepository, IMapper mapper)
        {
            _trimRepository = trimRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Trim>))]
        public IActionResult GetTypes()
        {
            var types = _mapper.Map<List<TrimDto>>(_trimRepository.GetTrims());

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(types);
        }

        [HttpGet("{typeId}")]
        [ProducesResponseType(200, Type = typeof(Trim))]
        [ProducesResponseType(400)]
        public IActionResult GetType(int typeId)
        {
            if (!_trimRepository.GetTrimExists(typeId)) return NotFound();
            var type = _mapper.Map<TrimDto>(_trimRepository.GetTrim(typeId));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(type);
        }
    }
}
