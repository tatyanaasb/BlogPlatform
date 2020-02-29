using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BlogPlatform.Controllers;
using BlogPlatform.Models;
using BlogPlatform.Repositories;

namespace BlogPlatform.Tests
{
    public class CategoryControllerTests
    {     
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Details_Returns_A_View()
        //{
        //    var underTest = new HomeController();

        //    var result = underTest.Details();

        //    Assert.IsType<ViewResult>(result);
        //}
    }
}
