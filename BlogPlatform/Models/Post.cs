using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }


        public Post()
        {
        }

        public Post(string title, string body, string author, DateTime publishDate)
        {
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }
    }



}
