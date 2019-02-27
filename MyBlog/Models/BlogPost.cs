using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{
    //a blog post item that we can pass to our database table so we can have multiple of these
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Posted { get; set; }
        [NotMapped]
        public string miniBody
        {
            get
            {
                if (Body.Length < 50)
                {
                    return Body;
                }
                else
                {
                    return Body.Substring(0, 50);
                }
            }
        }
    }
}
