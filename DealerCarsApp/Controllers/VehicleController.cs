using AutoMapper;
using DealerCarsApp.Data;
using DealerCarsApp.Dto;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace DealerCarsApp.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleController(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Vehicle>))]
        public IActionResult GetVehicles()
        {
            var vehicles = _mapper.Map<List<VehicleDto>>(_vehicleRepository.GetVehicles());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(vehicles);
        }

        [HttpGet("{vehicleId}")]
        [ProducesResponseType(200, Type=typeof(Vehicle))]
        [ProducesResponseType(400)]
        public IActionResult GetVehicle(int vehicleId)
        {
            if(!_vehicleRepository.GetVehicleExists(vehicleId)) return NotFound();

            var vehicle = _mapper.Map<VehicleDto>(_vehicleRepository.GetVehicle(vehicleId));

            if(!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(vehicle);
        }


    }
}
