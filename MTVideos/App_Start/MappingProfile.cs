using AutoMapper;
using MTVideos.Dtos;
using MTVideos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTVideos.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}