using Baker.WebApi.Context;
using Baker.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly BakerContext _context;

        public AboutController(BakerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _context.Abouts.FirstOrDefault();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Create(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return Ok("Kaydetme işlemi başarıyla gerçekleşti");
        }
        [HttpPut]
        public IActionResult Update(About about)
        {
            _context.Abouts.Update(about);   
            _context.SaveChanges();
            return Ok("Güncelleme başarılı");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarıyla gerçekleşti");
        }
        [HttpGet("{id}")] 
        public IActionResult GetById(int id)
        {
            var value = _context.Abouts.Find(id);
            return Ok(value);
        }
    }
}
