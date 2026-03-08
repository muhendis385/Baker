using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.WebApi.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
