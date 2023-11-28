using AutoMapper;
using Restaurant.Dto;
using Restaurant.Models;

namespace Restaurant.AutoMappers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<AddMenudto, Menu>().ReverseMap();

            CreateMap<Details,DetailsDto>().ReverseMap();


            
        }
    }
}
