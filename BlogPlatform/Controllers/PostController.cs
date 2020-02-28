using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogPlatform.Models;
using BlogPlatform.Repositories;

namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;

        //public PostController()
        //{
        //}

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }

        public ViewResult Index()
        {
            var model = postRepo.GetAll();

            return View(model);
        }

        //public ViewResult Index(string title)
        //{
        //    var model = new Post();
        //    model.Title = title;
        //    return View(model);
        //}
        
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
    }
}
