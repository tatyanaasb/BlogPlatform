using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private BlogContext db;
        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }
        public Category GetById(int id)
        {
            return db.Categories.Single(p => p.Id == id);
        }
        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }
        public void Update(Category obj)
        {
            throw new NotImplementedException();

        }
    }
}
