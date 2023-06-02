using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Core_Intro_dot_net_5.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Title { get; set; }
        [Required, Column(TypeName ="Date"),
            DataType(DataType.Date),
            Display(Name ="Publish Date"),
            DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime PublishDate { get; set; }
        public double Rating { get; set; }
    }

    public class ArticleDbContext : DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set;}
    }
}
