using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> courseCategoryService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = courseCategoryService.TGetList();
            return Ok(values);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = courseCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            courseCategoryService.TDelete(id);
            return Ok("Değer silindi");
        }

        [HttpPost]

        public IActionResult Post(CreateCourseCategoryDto createCoursCategoryeDto)
        {
            var newValue = mapper.Map<CourseCategory>(createCoursCategoryeDto);
            courseCategoryService.TCreate(newValue);
            return Ok("Değer Eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var value = mapper.Map<CourseCategory>(updateCourseCategoryDto);
            courseCategoryService.TUpdate(value);
            return Ok("Değer güncellendi");
        }
    }
}
