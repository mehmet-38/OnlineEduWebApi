﻿using AutoMapper;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Mapping
{
    public class MessageMapping:Profile
    {
        public MessageMapping() { 
        
            CreateMap<CreateMessageDto,Message>().ReverseMap();
            CreateMap<UpdateMessageDto,Message>().ReverseMap();
        }
    }
}
