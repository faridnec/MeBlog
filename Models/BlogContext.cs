//veritabani baglantisi
using System;
using Microsoft.EntityFrameworkCore;

//her context sinifi dbcontext sinifindan tuketilmelidir
namespace MeBlog.Models{
    public class BlogContext : DbContext{
        public BlogContext(DbContextOptions<BlogContext> options) : base(options){

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}