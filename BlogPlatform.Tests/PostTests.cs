using System;
using Xunit;
using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Tests
{
    public class PostTests
    {
        Post model;

        public PostTests()
        {
            model = new Post(001, "Author", "Post Title", "Body Text",  new DateTime(2011, 6, 10));
        }

        [Fact]
        public void Post_Id_Is_Id()
        {
            var result = model.Id;

            Assert.Equal(001, result);
        }

        [Fact]
        public void Post_Author_Is_Author()
        {
            var result = model.Author;

            Assert.Equal("Author", result);
        }

        [Fact]
        public void Post_Title_Is_PostTitle()
        {
            var result = model.Title;

            Assert.Equal("Post Title", result);
        }

        [Fact]
        public void Post_Body_Is_BodyText()
        {
            var result = model.Body;

            Assert.Equal("Body Text", result);
        }

        [Fact]
        public void Post_DateTime_Is_2011_06_10()
        {
            var result = model.PublishDate;

            Assert.Equal(model.PublishDate, result);
        }
    }
}