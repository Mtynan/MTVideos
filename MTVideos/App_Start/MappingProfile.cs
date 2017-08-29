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
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movies, MoviesDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            
            Mapper.CreateMap<MoviesDto, Movies>()
                           .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}