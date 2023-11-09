using AutoMapper;
using SignalR.EntityLayer.Entities;
using SlgnalR.DtoLayer.FeatureDto;

namespace SignalRApi.Mapping
{
    public class FeatureMapping :Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        }
    }
}
