using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboutEG.Models
{
    public class Category
    {
        public Category()
        {
            Posts = new List<Post>();

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SlugUrl{ get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}