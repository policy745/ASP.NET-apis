using AutoMapper;

namespace WebApi.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Model.Domain.Region, Model.Domain.Region>()
                .ReverseMap();
        }
    }
}
