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
        private readonly ITypesRepository _typesRepository;
        private readonly IMapper _mapper;

        public TypesController(ITypesRepository typesRepository, IMapper mapper)
        {
            _typesRepository = typesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Types>))]
        public IActionResult GetTypes()
        {
            var types = _mapper.Map<List<TypesDto>>(_typesRepository.GetTypes());

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(types);
        }

        [HttpGet("{typeId}")]
        [ProducesResponseType(200, Type = typeof(Types))]
        [ProducesResponseType(400)]
        public IActionResult GetType(int typeId)
        {
            if (!_typesRepository.GetTypeExists(typeId)) return NotFound();
            var type = _mapper.Map<TypesDto>(_typesRepository.GetType(typeId));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(type);
        }
    }
}
