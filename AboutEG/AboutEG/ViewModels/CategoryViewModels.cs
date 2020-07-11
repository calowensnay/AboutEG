using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace AboutEG.ViewModels
{
    public class CategoryIndexViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostIndexViewModel> Posts { get; set; }



    }

    public class CategoryCreateViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostCreateViewModel> Posts { get; set; }

    }

    public class CategoryEditViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostEditViewModel> Posts { get; set; }

    }

    public class CategoryDetailViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostDetailViewModel> Posts { get; set; }

    }

    public class CategoryDeleteViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Posts")]
        public virtual ICollection<PostDeleteViewModel> Posts { get; set; }

    }
}