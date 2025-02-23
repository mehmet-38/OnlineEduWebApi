using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> bannerService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            var values = bannerService.TGetList();
            return Ok(values);
        
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
            var value = bannerService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 

            bannerService.TDelete(id);

            return Ok("Banner silindi");
        
        }

        [HttpPost]

        public IActionResult Post(CreateBannerDto createBannerDto) {
            //Bu satır, CreateBannerDto nesnesini Banner nesnesine çeviriyor.
            //AutoMapper, eşleşen alanları otomatik olarak kopyalar. 
            var newValue = mapper.Map<Banner>(createBannerDto);
            bannerService.TCreate(newValue);

            return Ok("Banner Eklendi");

        }

        [HttpPut]
        public IActionResult Put(UpdateBannerDto updateBannerDto) { 

            var value = mapper.Map<Banner>(updateBannerDto);
            bannerService.TUpdate(value);
            return Ok("Banner Güncellendi");
        
        
        }


    }
}
