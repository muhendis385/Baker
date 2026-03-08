using Baker.WebApi.Context;
using Baker.WebApi.Dto;
using Baker.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BakerContext _context;

        public CategoryController(BakerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _context.Categorys.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryDto dto)
        {
            var category = new Category
            {
                CategoryName = dto.CategoryName,
                CategoryDescription = dto.CategoryDescription
            };
            _context.Categorys.Add(category);
            _context.SaveChanges();
            return Ok("Kayıt başarılı");
        }
        [HttpPut]
        public IActionResult Update(Category category)
        {
            _context.Categorys.Update(category);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarıyla gerçekleşti");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _context.Categorys.Find(id);
            _context.Categorys.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarıyla gerçekleşti");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _context.Categorys.Find(id);
            return Ok(value);
        }

        [HttpGet("CountCategory")]
        public IActionResult GetCategory()
        {
            var categoryCount = _context.Categorys.Count();
            return Ok(categoryCount);
        }
    }
}
