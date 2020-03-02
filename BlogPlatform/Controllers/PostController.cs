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

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }

        public ViewResult Index()
        {
            var model = postRepo.GetAll().ToList();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = postRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            postRepo.Create(post);
            return RedirectToAction("Index", "Post", new { id = post.Id });
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Post model = postRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            postRepo.Update(post);

            return RedirectToAction("Index", "Post", new { id = post.Id });
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            Post model = postRepo.GetById(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Post post)
        {
            postRepo.Delete(post);

            return RedirectToAction("Index", "Post");
        }
    }
}
