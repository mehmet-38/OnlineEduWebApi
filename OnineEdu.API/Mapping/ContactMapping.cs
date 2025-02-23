using AutoMapper;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping() { 
        
            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<UpdateContactDto,Contact>().ReverseMap();
        }
    }
}
