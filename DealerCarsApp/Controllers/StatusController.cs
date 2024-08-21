using AutoMapper;
using DealerCarsApp.CreateDto;
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


        [HttpPost]
        public ActionResult CreateStatus([FromBody] CreateStatusDto createStatusDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var status = _mapper.Map<Status>(createStatusDto);

            try
            {
                _statusRepository.CreateStatus(status);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var statusDto = _mapper.Map<StatusDto>(status);
            return Ok(statusDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStatus(int id, CreateStatusDto updateStatusDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_statusRepository.StatusExists(id))
                return NotFound();

            var updateStatus = _mapper.Map<Status>(updateStatusDto);
            updateStatus.Id = id;

            try
            {
                _statusRepository.UpdateStatus(updateStatus);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var statusDto = _mapper.Map<StatusDto>(updateStatus);

            return Ok(statusDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStatus(int id)
        {
            if (!_statusRepository.StatusExists(id))
                return NotFound();

            var status = _statusRepository.GetStatus(id);

            try
            {
                _statusRepository.DeleteStatus(status);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
