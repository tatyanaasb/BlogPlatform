using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Category()
        {
        }

        public Category(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
