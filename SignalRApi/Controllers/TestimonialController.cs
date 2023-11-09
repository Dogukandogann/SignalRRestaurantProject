using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SlgnalR.DtoLayer.TestimonialDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestomonialService _testomonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestomonialService testomonialService, IMapper mapper)
        {
            _testomonialService = testomonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testomonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto testimonialDto)
        {
            _testomonialService.TAdd(new Testimonial()
            {
                Comment=testimonialDto.Comment,
                ImageUrl=testimonialDto.ImageUrl,
                Name=testimonialDto.Name,
                Status = testimonialDto.Status,
                Title = testimonialDto.Title,
                
            });
            return Ok("Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testomonialService.TGetByID(id);
            _testomonialService.TDelete(value);
            return Ok("Silindi");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testomonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testomonialService.TAdd(new Testimonial()
            {
                TestimonialID=updateTestimonialDto.TestimonialID,
                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title,

            });
            return Ok("Güncellendi");
        }
    }
}
