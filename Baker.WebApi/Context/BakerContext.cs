using Baker.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Baker.WebApi.Context
{
    public class BakerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-LUFN22OD\\SQLEXPRESS; initial catalog=DbBakerAkademiq;integrated Security = true; trust server certificate=true");
        }

        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<AdressInfo> AdressInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        


    }
}
