﻿using System;
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
            model = new Post("Post Name", "Body Text", "Author", new DateTime(2011, 6, 10));
        }

        [Fact]
        public void Post_Title_Is_PostName()
        {
            var result = model.Title;

            Assert.Equal("Post Name", result);
        }

        [Fact]
        public void Post_Body_Is_BodyText()
        {
            var result = model.Body;

            Assert.Equal("Body Text", result);
        }

        [Fact]
        public void Post_Author_Is_Author()
        {
            var result = model.Author;

            Assert.Equal("Author", result);
        }
    }
}