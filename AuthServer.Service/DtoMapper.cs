using AuthServer.Core.DTOs;
using AuthServer.Core.models;
using AutoMapper;


namespace AuthServer.Service
{
    class DtoMapper: Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
