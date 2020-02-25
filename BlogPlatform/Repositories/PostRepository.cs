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
        public int Count()
        {
            return db.Posts.Count();
        }
    }
}
