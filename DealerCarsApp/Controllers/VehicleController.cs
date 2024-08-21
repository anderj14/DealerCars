using AutoMapper;
using DealerCarsApp.CreateDto;
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

        [HttpGet("{vehicleId}", Name = "GetVehicle")]
        [ProducesResponseType(200, Type = typeof(Vehicle))]
        [ProducesResponseType(400)]
        public IActionResult GetVehicle(int vehicleId)
        {
            if (!_vehicleRepository.GetVehicleExists(vehicleId)) return NotFound();

            var vehicle = _mapper.Map<VehicleDto>(_vehicleRepository.GetVehicle(vehicleId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(vehicle);
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(VehicleDto))]
        public ActionResult CreateVehicle([FromBody] CreateVehicle createVehicleDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (_vehicleRepository.GetVIN(createVehicleDto.VIN) != null)
            {
                ModelState.AddModelError("", "The VIN vehicle exist!");
                return UnprocessableEntity(ModelState);
            }

            var vehicle = _mapper.Map<Vehicle>(createVehicleDto);

            try
            {
                _vehicleRepository.CreateVehicle(vehicle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var vehicleDto = _mapper.Map<VehicleDto>(vehicle);
            return CreatedAtAction(nameof(GetVehicle), new { id = vehicle.Id }, vehicleDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehicle(int id, CreateVehicle updateVehicleDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_vehicleRepository.GetVehicleExists(id))
            {
                return NotFound();
            }

            var updateVehicle = _mapper.Map<Vehicle>(updateVehicleDto);
            updateVehicle.Id = id;

            try
            {
                _vehicleRepository.UpdateVehicle(updateVehicle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            if (!_vehicleRepository.GetVehicleExists(id))
            {
                return NotFound();
            }

            var vehicle = _vehicleRepository.GetVehicle(id);

            try
            {
                _vehicleRepository.DeleteVehicle(vehicle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }


    }
}
