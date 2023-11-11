
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SlgnalR.DtoLayer.AboutDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                AboutTitle = createAboutDto.AboutTitle,
                AboutDescription = createAboutDto.AboutDescription,
                AboutImageUrl = createAboutDto.AboutImageUrl,

            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda Eklendi");
        }
        [HttpDelete("{id}")]

        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID=updateAboutDto.AboutID,
               AboutImageUrl=updateAboutDto.AboutImageUrl,
               AboutDescription=updateAboutDto.AboutDescription,
               AboutTitle = updateAboutDto.AboutTitle
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }

    }
}
