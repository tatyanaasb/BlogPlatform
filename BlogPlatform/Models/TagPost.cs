using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class TagPost
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }

        public TagPost()
        {
        }

        public TagPost(int id, int postId, int tagId)
        {
            Id = id;
            PostId = postId;
            TagId = tagId;
        }
    }
}
