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

            if(!ModelState.IsValid)
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
    }
}
