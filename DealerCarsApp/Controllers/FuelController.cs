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
    public class FuelController : Controller
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly IMapper _mapper;

        public FuelController(IFuelRepository fuelRepository , IMapper mapper)
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
    }   
}
