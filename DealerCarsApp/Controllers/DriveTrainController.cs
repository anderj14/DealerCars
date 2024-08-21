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
    public class DriveTrainController : Controller
    {
        private readonly IDriveTrainRepository _driveTrainRepository;
        private readonly IMapper _mapper;

        public DriveTrainController(IDriveTrainRepository driveTrainRepository, IMapper mapper)
        {
            _driveTrainRepository = driveTrainRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetDriveTrains()
        {
            var driveTrains = _mapper.Map<List<DriveTrainDto>>(_driveTrainRepository.GetDriveTrains());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(driveTrains);
        }

        [HttpGet("{driveTrainId}")]
        [ProducesResponseType(200, Type = typeof(DriveTrain))]
        [ProducesResponseType(400)]
        public IActionResult GetDriveTrain(int driveTrainId)
        {
            if (!_driveTrainRepository.DriveTrainExists(driveTrainId)) return NotFound();

            var driveTrain = _mapper.Map<DriveTrainDto>(_driveTrainRepository.GetDriveTrain(driveTrainId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(driveTrain);
        }

        [HttpPost]
        public ActionResult CreateDriveTrain([FromBody] CreateDriveTrainDto createDriveTrainDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var driveTrain = _mapper.Map<DriveTrain>(createDriveTrainDto);

            try
            {
                _driveTrainRepository.CreateDriveTrain(driveTrain);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var DriveTrainDto = _mapper.Map<DriveTrainDto>(driveTrain);
            return Ok(DriveTrainDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDriveTrain(int id, CreateDriveTrainDto updateDriveTrainDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_driveTrainRepository.DriveTrainExists(id))
                return NotFound();

            var updateDriveTrain = _mapper.Map<DriveTrain>(updateDriveTrainDto);
            updateDriveTrain.Id = id;

            try
            {
                _driveTrainRepository.UpdateDriveTrain(updateDriveTrain);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var DriveTrainDto = _mapper.Map<DriveTrainDto>(updateDriveTrain);

            return Ok(DriveTrainDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDriveTrain(int id)
        {
            if (!_driveTrainRepository.DriveTrainExists(id))
                return NotFound();

            var driveTrain = _driveTrainRepository.GetDriveTrain(id);

            try
            {
                _driveTrainRepository.DeleteDriveTrain(driveTrain);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
