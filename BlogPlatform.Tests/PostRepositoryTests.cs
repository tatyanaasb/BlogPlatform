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
        
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new BlogContext();
            var underTest = new PostRepository(db);

            var count = underTest.Count();

            Assert.Equal(0, count);
        }
        [Fact]
        public void Create_Increases_Count()
        {
            var db = new BlogContext();
            var underTest = new PostRepository(db);

            underTest.Create(new Post() { Title = "Backpack" });

            var count = underTest.Count();
            Assert.Equal(1, count);
        }
    }
}
