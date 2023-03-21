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

            if(!ModelState.IsValid)
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

        [HttpGet("vehicle/{driveTrainId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DriveTrain>))]
        [ProducesResponseType(400)]
        public IActionResult GetVehicleByDriveTrainId(int driveTrainId)
        {
            var driveTrain = _mapper.Map<List<VehicleDto>>(_driveTrainRepository.GetVehiclesByDriveTrain(driveTrainId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(driveTrain);
        }
    }
}
