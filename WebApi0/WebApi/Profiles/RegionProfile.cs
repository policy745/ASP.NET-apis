using AutoMapper;

namespace WebApi.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Model.Domain.Region, Model.DTOs.Region>()
                .ReverseMap();
        }
    }
}
