using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace AboutEG.ViewModels
{
    public class TagIndexViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public int SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostIndexViewModel> Posts { get; set; }



    }

    public class TagCreateViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public int SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostCreateViewModel> Posts { get; set; }

    }

    public class TagEditViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public int SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostEditViewModel> Posts { get; set; }

    }

    public class TagDetailViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public int SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostDetailViewModel> Posts { get; set; }

    }

    public class TagDeleteViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public int SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostDeleteViewModel> Posts { get; set; }

    }
}