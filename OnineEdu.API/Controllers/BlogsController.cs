﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> blogService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            var values = blogService.TGetList();
            return Ok(values);

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
        
            var value = blogService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 
            blogService.TDelete(id);
            return Ok("Blog Silindi");
        }
        [HttpPost]

        public IActionResult Create(CreateBlogDto createBlogDto) { 
        
            var newValue = mapper.Map<Blog>(createBlogDto);

            blogService.TCreate(newValue);

            return Ok("Blog Eklendi");
        }
        [HttpPut]

        public IActionResult Update(UpdateBlogDto updateBlogDto) { 
        
            var value = mapper.Map<Blog>(updateBlogDto);

            blogService.TUpdate(value);
            return Ok("Blog güncellendi");
        }
    }
}
