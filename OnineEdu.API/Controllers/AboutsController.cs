using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // burada genericService den içine hangi entity ile çalışacağını veriyorsun
    public class AboutsController(IGenericService<About> aboutService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = aboutService.TGetList();
            return Ok(values);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
           var value = aboutService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            aboutService.TDelete(id);
            return Ok("Değer silindi");
        }

        [HttpPost]

        public IActionResult Post(CreateAboutDto createAboutDto) {
            var newValue = mapper.Map<About>(createAboutDto);
            aboutService.TCreate(newValue);
            return Ok("Değer Eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto) { 
            var value = mapper.Map<About>(updateAboutDto);
            aboutService.TUpdate(value);
            return Ok("Değer güncellendi");
        }

    }
}
