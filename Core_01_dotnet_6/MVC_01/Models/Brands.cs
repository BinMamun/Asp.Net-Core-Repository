using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_01.Models
{
    public class Brand
    {        
        public int BrandId { get; set; }
        [Required, StringLength(40), Display(Name = "Brand Name")]
        public string BrandName { get; set; }
        [Required, StringLength(30), Display(Name = "Origin")]
        public string Origin { get; set; }        
    }

    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<Brand> Brands { get; set; }       
    }
}
