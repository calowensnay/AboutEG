using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AboutEG.Models
{
    public class Post
    {
        public Post()
        {
            Tags = new List<Tag>();

        }
        public int Id { get; set; }

        public string SubTitle { get; set;}
        public string Title { get; set; }
        public string SlugUrl  { get; set; }
        public DateTime PostDate { get; set; }
       // [DataType(DataType.MultilineText)]
        public string HtmlContent { get; set; }
        public bool IsProvisional { get; set; }
        public DateTime PublishDate { get; set; }
        public string Ahutor { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public bool IsPublic => !IsProvisional && PublishDate <= DateTime.Now;
    }
}