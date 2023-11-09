using AutoMapper;
using SignalR.EntityLayer.Entities;
using SlgnalR.DtoLayer.DiscountDto;

namespace SignalRApi.Mapping
{
    public class DiscountMapping :Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        }
    }
}
