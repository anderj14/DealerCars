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
    public class BrandController : Controller
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandController(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Brand>))]
        public IActionResult GetBrands()
        {
            var brand = _mapper.Map<List<BrandDto>>(_brandRepository.GetBrands());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(brand);
        }

        [HttpGet("{brandId}")]
        [ProducesResponseType(200, Type = typeof(Brand))]
        [ProducesResponseType(400)]
        public IActionResult GetBrand(int brandId)
        {
            if (!_brandRepository.BrandExists(brandId)) return NotFound();

            var brand = _mapper.Map<BrandDto>(_brandRepository.GetBrand(brandId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(brand);
        }

        [HttpGet("vehicle/{brandId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Brand>))]
        [ProducesResponseType(400)]
        public IActionResult GetVehicleByBrandId(int brandId)
        {
            var brands = _mapper.Map<List<VehicleDto>>(_brandRepository.GetVehiclesByBrand(brandId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(brands);
        }

        [HttpGet("{brandId}/models")]
        public IActionResult GetModelsByABrand(int brandId)
        {
            if (!_brandRepository.BrandExists(brandId)) return NotFound();

            var models = _mapper.Map<List<ModelDto>>(_brandRepository.GetModelsByBrand(brandId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(models);
        }
    }
}
