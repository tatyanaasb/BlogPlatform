using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;
        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }
        
        public Post GetById(int id)
        {
            return db.Posts.Single(p => p.Id == id);
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Update(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }
    }
}
