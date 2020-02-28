using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlogPlatform.Controllers;
using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Tests
{
    public class PostControllerTests
    {
        [Fact]
        public void Index_Sets_Title_On_Model()
        {
            var expectedTitle = "Title String";
            var controller = new PostController();

            var result = controller.Index(expectedTitle);

            var model = (Post)result.Model;
            Assert.Equal(expectedTitle, model.Title);
        }
    }
}
