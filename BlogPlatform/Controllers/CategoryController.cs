using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogPlatform.Models;
using BlogPlatform.Repositories;


namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            Category model = categoryRepo.GetById(id);

            return View(model);
        }
    }
}