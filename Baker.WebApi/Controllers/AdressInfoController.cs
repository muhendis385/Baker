using Baker.WebApi.Context;
using Baker.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressInfoController : ControllerBase
    {
        private readonly BakerContext _context;

        public AdressInfoController(BakerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AdressList()
        {
            var values = _context.AdressInfos.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Create(AdressInfo adress)
        {
            _context.AdressInfos.Add(adress);
            _context.SaveChanges();
            return Ok("Kaydetme işlemi başarıyla gerçekleşti");
        }
        [HttpPut]
        public IActionResult Update(AdressInfo adress)
        {
            _context.AdressInfos.Update(adress);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarıyla gerçekleşti");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _context.AdressInfos.Find(id);
            _context.AdressInfos.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarıyla gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var chef = _context.AdressInfos.Find(id);
            return Ok(chef);
        }
    }
}
