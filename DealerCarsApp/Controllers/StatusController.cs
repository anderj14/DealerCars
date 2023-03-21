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
    public class StatusController : Controller
    {
        private readonly IStatusRepository _statusRepository;
        private readonly IMapper _mapper;

        public StatusController(IStatusRepository statusRepository, IMapper mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Status>))]
        public IActionResult GetStatuses()
        {
            var statuses = _mapper.Map<List<StatusDto>>(_statusRepository.GetStatuses());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(statuses);
        }

        [HttpGet("{statusId}")]
        [ProducesResponseType(200, Type = typeof(Status))]
        [ProducesResponseType(400)]
        public IActionResult GetStatus(int statusId)
        {
            if (!_statusRepository.StatusExists(statusId)) return NotFound();

            var status = _mapper.Map<StatusDto>(_statusRepository.GetStatus(statusId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(status);
        }

        [HttpGet("vehicle/{statusId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Status>))]
        [ProducesResponseType(400)]
        public IActionResult GetVehicleByStatusId(int statusId)
        {
            var status = _mapper.Map<List<VehicleDto>>(_statusRepository.GetVehiclesByStatus(statusId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(status);
        }
    }
}
