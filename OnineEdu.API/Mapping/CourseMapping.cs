﻿using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entities;

namespace OnineEdu.API.Mapping
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseDto, Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<ResultCourseDto, Course>().ReverseMap();
            
        }
    }
}
