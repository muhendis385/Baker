using Baker.WebApi.Context;
using Baker.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly BakerContext _context;

        public SubscribeController(BakerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _context.Subscribes.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Create(Subscribe subscribe)
        {
            _context.Subscribes.Add(subscribe);
            _context.SaveChanges();
            return Ok("Kaydetme işlemi başarıyla gerçekleşti");
        }
        [HttpPut]
        public IActionResult Update(Subscribe subscribe)
        {
            _context.Subscribes.Update(subscribe);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarıyla gerçekleşti");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _context.Subscribes.Find(id);
            _context.Subscribes.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarıyla gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _context.Subscribes.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return Ok(value);
        }
    }
}
