﻿using AutoMapper;
using BusinessLogic.IService.IDepartmentService.Dto;
using Data.Entities;

namespace BusinessLogic.Mapper
{
    public class DepartmentMapperProfile : Profile
    {
        public DepartmentMapperProfile() 
        {
            CreateMap<DepartmentAddDto, Department>();
            CreateMap<DepartmentUpdateDto, Department>();
            CreateMap<Department, DepartmentByIdDto>().ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
