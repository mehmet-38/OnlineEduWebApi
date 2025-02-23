using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> messageService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = messageService.TGetList();
            return Ok(values);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = messageService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            messageService.TDelete(id);
            return Ok("Değer silindi");
        }

        [HttpPost]

        public IActionResult Post(CreateMessageDto createMessageDto)
        {
            var newValue = mapper.Map<Message>(createMessageDto);
            messageService.TCreate(newValue);
            return Ok("Değer Eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDto updateMessageDto)
        {
            var value = mapper.Map<Message>(updateMessageDto);
            messageService.TUpdate(value);
            return Ok("Değer güncellendi");
        }
    }
}
