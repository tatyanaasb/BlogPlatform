using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogPlatform.Models;
using BlogPlatform.Repositories;

namespace BlogPlatform.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> tagRepo;

        public TagController(IRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        public ViewResult Index()
        {
            var model = tagRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            Tag model = tagRepo.GetById(id);

            return View(model);
        }
    }
}