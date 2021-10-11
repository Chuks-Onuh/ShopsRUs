using AutoMapper;
using ShopsRUs.API.DTOs;
using ShopsRUs.Domain.Models;

namespace ShopsRUs.API.AutoMapper
{
    public class MappingCustomer : Profile
    {
        public MappingCustomer()
        {
            CreateMap<AppUser, CustomerForCreationDto>().ReverseMap();
        }
    }
}
