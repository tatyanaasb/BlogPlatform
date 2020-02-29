using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlogPlatform.Models;
using BlogPlatform.Repositories;

namespace BlogPlatform.Tests
{
    public class PostRepositoryTests : IDisposable
    {
        private BlogContext db;
        private PostRepository underTest;

        public PostRepositoryTests()
        {
            db = new BlogContext();
            db.Database.BeginTransaction();

            underTest = new PostRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }
    }
}
