using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public int Id { get; set; }

        // Many-Many relationship with Post:Tag to be implemented here...
        public Tag()
        {
        }

        public Tag(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
