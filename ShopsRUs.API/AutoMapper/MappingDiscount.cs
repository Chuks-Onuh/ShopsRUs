using AutoMapper;
using ShopsRUs.API.DTOs;
using ShopsRUs.Domain.Models;

namespace ShopsRUs.API.AutoMapper
{
    public class MappingDiscount : Profile
    {
        public MappingDiscount()
        {
            CreateMap<Discount, DiscountForCreationDto>().ReverseMap();
        }
    }
}
