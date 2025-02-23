using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> blogCategoryService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() { 
            var values = blogCategoryService.TGetList();
            return Ok(values);
        

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
        
            var value = blogCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 
        
            blogCategoryService.TDelete(id);
            return Ok("Blog Kategori silindi");
        }

        [HttpPost]

        public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
        {
            var newValue = mapper.Map<BlogCategory>(createBlogCategoryDto);
            blogCategoryService.TCreate(newValue);
            return Ok("Blog Kategori Eklendi");

        }
        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto) {

            var value = mapper.Map<BlogCategory>(updateBlogCategoryDto);
            blogCategoryService.TUpdate(value);
            return Ok("Blog Kategori Güncellendi");
        }


    }
}
