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
    public class FuelController : Controller
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly IMapper _mapper;

        public FuelController(IFuelRepository fuelRepository, IMapper mapper)
        {
            _fuelRepository = fuelRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Fuel>))]
        public IActionResult GetFuels()
        {
            var fuels = _mapper.Map<List<FuelDto>>(_fuelRepository.GetFuels());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(fuels);
        }

        [HttpGet("{fuelId}")]
        [ProducesResponseType(200, Type = typeof(Fuel))]
        [ProducesResponseType(400)]
        public IActionResult GetFuel(int fuelId)
        {
            if (!_fuelRepository.FuelExists(fuelId)) return NotFound();

            var fuels = _mapper.Map<FuelDto>(_fuelRepository.GetFuel(fuelId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(fuels);
        }

        [HttpGet("vehicle/{fueldId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Fuel>))]
        [ProducesResponseType(400)]
        public IActionResult GetVehicleByfuelId(int fueldId)
        {
            var fuels = _mapper.Map<List<VehicleDto>>(_fuelRepository.GetVehicleByFuel(fueldId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(fuels);
        }

        [HttpPost]
        public ActionResult CreateFuel([FromBody] CreateFuelDto createFuelDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var fuel = _mapper.Map<Fuel>(createFuelDto);

            try
            {
                _fuelRepository.CreateFuel(fuel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var fuelDto = _mapper.Map<FuelDto>(fuel);
            return Ok(fuelDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFuel(int id, CreateFuelDto updateFuelDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_fuelRepository.FuelExists(id))
                return NotFound();

            var updateFuel = _mapper.Map<Fuel>(updateFuelDto);
            updateFuel.Id = id;

            try
            {
                _fuelRepository.UpdateFuel(updateFuel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var trimDto = _mapper.Map<FuelDto>(updateFuel);

            return Ok(trimDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFuel(int id)
        {
            if (!_fuelRepository.FuelExists(id))
                return NotFound();

            var trim = _fuelRepository.GetFuel(id);

            try
            {
                _fuelRepository.DeleteFuel(trim);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
