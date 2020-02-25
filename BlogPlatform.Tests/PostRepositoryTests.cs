using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlogPlatform.Models;
using BlogPlatform.Repositories;

namespace BlogPlatform.Tests
{
    public class PostRepositoryTests
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new BlogContext();
            var underTest = new PostRepository(db);

            var count = underTest.Count();

            Assert.Equal(0, count);
        }
    }
}
