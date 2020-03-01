using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }

        // Attempting 1-Many with Category:Post
        //[Display(Name = "Select a Category: ")]
        public virtual Category Category { get; set; }
        public virtual int CategoryId { get; set; }

        public Post()
        {
        }

        public Post(int id, string author, string title, string body, DateTime publishDate)
        {
            Id = id;
            Author = author;
            Title = title;
            Body = body;
            PublishDate = publishDate;
        }
    }



}
