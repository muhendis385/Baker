using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.WebUI.Dtos.Product
{
    public class ProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
