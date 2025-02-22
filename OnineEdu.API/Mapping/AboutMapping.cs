using AutoMapper;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
