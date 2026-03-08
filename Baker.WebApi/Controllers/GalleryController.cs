using Baker.WebApi.Context;
using Baker.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly BakerContext _context;

        public GalleryController(BakerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GalleryList()
        {
            var values = _context.Gallerys.FirstOrDefault();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Create(Gallery gallery)
        {
            _context.Gallerys.Add(gallery);
            _context.SaveChanges();
            return Ok("Kaydetme işlemi başarıyla gerçekleşti");
        }
        [HttpPut]
        public IActionResult Update(Gallery gallery)
        {
            _context.Gallerys.Update(gallery);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarıyla gerçekleşti");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _context.Gallerys.Find(id);
            _context.Gallerys.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarıyla gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetGallery(int id)
        {
            var value = _context.Gallerys.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return Ok(value);
        }
    }
}
