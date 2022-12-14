using System;

namespace MeBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; } // veritabani test ederek dosyanin yolunu kaydetmekte
        public bool IsPublish { get; set; } // yazilan bloklar direkt

        public DateTime CreateTime{get;set;}=DateTime.Now;
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}