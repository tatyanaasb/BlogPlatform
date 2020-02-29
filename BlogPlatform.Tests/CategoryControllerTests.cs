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
        CategoryController testController;
        
        public CategoryControllerTests()
        {

        }

        [Fact]
        public void Index_Returns_ViewResult()
        {
            var result = testController.Index();

            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Details_Returns_A_View()
        //{
        //    var result = testController.Details(1);

        //    Assert.IsType<ViewResult>(result);
        //}
    }
}
