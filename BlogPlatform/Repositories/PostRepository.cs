using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class PostRepository
    {
        private BlogContext db;
        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public Post GetById(int id)
        {
            return db.Posts.Single(p => p.Id == id);
        }
        public int Count()
        {
            return db.Posts.Count();
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}
