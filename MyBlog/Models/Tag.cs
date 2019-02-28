using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PostTag> PostTags { get; set; }
    }

    public class PostTag
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public int PostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
