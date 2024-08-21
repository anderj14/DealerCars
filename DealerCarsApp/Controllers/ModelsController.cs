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


        [HttpPost]
        public ActionResult CreateModel([FromBody] CreateModelsDto createModelsDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var model = _mapper.Map<Models>(createModelsDto);

            try
            {
                _modelRepository.CreateModel(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var modelDto = _mapper.Map<ModelDto>(model);
            return Ok(modelDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateModel(int id, CreateModelsDto updateModelsDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_modelRepository.ModelExists(id))
                return NotFound();

            var updateModel = _mapper.Map<Models>(updateModelsDto);
            updateModel.Id = id;

            try
            {
                _modelRepository.UpdateModel(updateModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var trimDto = _mapper.Map<ModelDto>(updateModel);

            return Ok(trimDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteModel(int id)
        {
            if (!_modelRepository.ModelExists(id))
                return NotFound();

            var trim = _modelRepository.GetModel(id);

            try
            {
                _modelRepository.DeleteModel(trim);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
