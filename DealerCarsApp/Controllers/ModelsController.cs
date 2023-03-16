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
    public class ModelsController : Controller
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public ModelsController(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Models>))]
        public IActionResult GetModels()
        {
            var models = _mapper.Map<List<ModelDto>>(_modelRepository.GetModels());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(models);
        }


        [HttpGet("{modelId}")]
        [ProducesResponseType(200, Type = typeof(Models))]
        [ProducesResponseType(400)]
        public IActionResult GetBrand(int modelId)
        {
            if (!_modelRepository.ModelExists(modelId)) return NotFound();

            var brand = _mapper.Map<ModelDto>(_modelRepository.GetModel(modelId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(brand);
        }

        [HttpGet("{modelId}/types")]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<Models>))]
        //[ProducesResponseType(400)]
        public IActionResult GetTypeByAModel(int modelId)
        {
            var types = _mapper.Map<List<TypesDto>>(_modelRepository.GetTypeByModel(modelId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(types);
        }
    }
}
