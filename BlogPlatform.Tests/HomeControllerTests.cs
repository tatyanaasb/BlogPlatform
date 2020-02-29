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
        [Fact]
        public void Index_Passes_AllModels_To_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsAssignableFrom<HomeController>(result.Model);
        }
    }
}
