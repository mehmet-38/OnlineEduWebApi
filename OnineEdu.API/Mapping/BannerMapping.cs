using AutoMapper;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Mapping
{
    public class BannerMapping:Profile
    {
        public BannerMapping() { 
        CreateMap<CreateBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();

        }
        
    }
}
