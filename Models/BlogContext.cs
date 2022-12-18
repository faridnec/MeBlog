//veritabani baglantisi
using System;
using Microsoft.EntityFrameworkCore;

//her context sinifi dbcontext sinifindan tuketilmelidir
namespace MeBlog.Models{
    public class BlogContext : DbContext{
        public BlogContext(DbContextOptions<BlogContext> options) : base(options){

        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Blog> Blog { get; set; }
    }
}