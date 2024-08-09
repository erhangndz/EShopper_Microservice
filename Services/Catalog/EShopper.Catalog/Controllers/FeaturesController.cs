using AutoMapper;
using EShopper.Catalog.Dtos.FeatureDtos;
using EShopper.Catalog.Entities;
using EShopper.Catalog.Services.FeatureServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;  
        private readonly IMapper _mapper;

        public FeaturesController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _featureService.GetAllAsync();
            var mappedValues = _mapper.Map<List<ResultFeatureDto>>(values);
            return Ok(mappedValues);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            await _featureService.CreateAsync(value);
            return Ok("Yeni Öne Çıkan Alan Eklendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(string id)
        {
            var value = await _featureService.GetByIdAsync(id);
            var mappedValue = _mapper.Map<GetFeatureByIdDto>(value);
            return Ok(mappedValue);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var values = _mapper.Map<Feature>(updateFeatureDto);
            await _featureService.UpdateAsync(values);
            return Ok("Öne Çıkan Alan Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _featureService.DeleteAsync(id);
            return Ok("Öne Çıkan Alan Silindi");
        }


    }
}
