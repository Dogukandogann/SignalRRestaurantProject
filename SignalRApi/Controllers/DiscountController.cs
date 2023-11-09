using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SlgnalR.DtoLayer.DiscountDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto discountDto)
        {
            _discountService.TAdd(new Discount()
            {
             Amount=discountDto.Amount,
             Description=discountDto.Description,
             ImageUrl=discountDto.ImageUrl,
             Title= discountDto.Title
            });
            return Ok("Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("Silindi");
        }
        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                DiscountID=updateDiscountDto.DiscountID,
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageUrl = updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title
            });
            return Ok("Güncellendi");
        }
    }
}
