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
    public class BodyStyleController : Controller
    {
        private readonly IBodyStyleRepository _bodyStyleRepository;
        private readonly IMapper _mapper;

        public BodyStyleController(IBodyStyleRepository bodyStyleRepository, IMapper mapper)
        {
            _bodyStyleRepository = bodyStyleRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBodyStyles()
        {
            var bodyStyle = _mapper.Map<List<BodyStyleDto>>(_bodyStyleRepository.GetBodyStyles());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(bodyStyle);
        }

        [HttpGet("{bodyStyleId}")]
        [ProducesResponseType(200, Type = typeof(BodyStyle))]
        [ProducesResponseType(400)]
        public IActionResult GetBodyStyle(int bodyStyleId)
        {
            if (!_bodyStyleRepository.BodyStyleExists(bodyStyleId)) return NotFound();

            var bodyStyle = _mapper.Map<BodyStyleDto>(_bodyStyleRepository.GetBodyStyle(bodyStyleId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(bodyStyle);
        }

        [HttpPost]
        public ActionResult CreateBodyStyle([FromBody] CreateBodyStyleDto createBodyStyleDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var bodyStyle = _mapper.Map<BodyStyle>(createBodyStyleDto);

            try
            {
                _bodyStyleRepository.CreateBodyStyle(bodyStyle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var BodyStyleDto = _mapper.Map<BodyStyleDto>(bodyStyle);
            return Ok(BodyStyleDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBodyStyle(int id, CreateBodyStyleDto updateBodyStyleDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_bodyStyleRepository.BodyStyleExists(id))
                return NotFound();

            var updateBodyStyle = _mapper.Map<BodyStyle>(updateBodyStyleDto);
            updateBodyStyle.Id = id;

            try
            {
                _bodyStyleRepository.UpdateBodyStyle(updateBodyStyle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var BodyStyleDto = _mapper.Map<BodyStyleDto>(updateBodyStyle);

            return Ok(BodyStyleDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBodyStyle(int id)
        {
            if (!_bodyStyleRepository.BodyStyleExists(id))
                return NotFound();

            var bodyStyle = _bodyStyleRepository.GetBodyStyle(id);

            try
            {
                _bodyStyleRepository.DeleteBodyStyle(bodyStyle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
