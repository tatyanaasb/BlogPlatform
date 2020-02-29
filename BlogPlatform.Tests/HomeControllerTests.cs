using System;
using Xunit;
using BlogPlatform.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
