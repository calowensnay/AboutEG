using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using AboutEG.ViewModels;
//using System.ComponentModel.DataAnnotations;

namespace AboutEG.ViewModels
{
    public class PostIndexViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Subtítulo")]
        public string SubTitle { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Fecha Creación")]
        public DateTime PostDate { get; set; }

        [DisplayName("Contenido")]
        public string HtmlContent { get; set; }

        [DisplayName("Es Borrador")]
        public bool IsProvisional { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime PublishDate { get; set; }

        [DisplayName("Autor")]
        public string Ahutor { get; set; }

        [DisplayName("Tags")]
        public virtual ICollection<TagIndexViewModel> Tags { get; set; }

        [DisplayName("Es Público")]
        public bool IsPublic => !IsProvisional && PublishDate <= DateTime.Now;
    }

    public class PostCreateViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Subtítulo")]
        public string SubTitle { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Fecha Creación")]
        public DateTime PostDate { get; set; }

        [DisplayName("Contenido")]
       // [DataType(DataType.MultilineText)]
        public string HtmlContent { get; set; }

        [DisplayName("Es Borrador")]
        public bool IsProvisional { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime PublishDate { get; set; }

        [DisplayName("Autor")]
        public string Ahutor { get; set; }

        [DisplayName("Tags")]
        public virtual ICollection<TagCreateViewModel> Tags { get; set; }

        [DisplayName("Es Público")]
        public bool IsPublic => !IsProvisional && PublishDate <= DateTime.Now;
    }

    public class PostEditViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Subtítulo")]
        public string SubTitle { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Fecha Creación")]
        public DateTime PostDate { get; set; }

        [DisplayName("Contenido")]
     //   [DataType(DataType.MultilineText)]
        public string HtmlContent { get; set; }

        [DisplayName("Es Borrador")]
        public bool IsProvisional { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime PublishDate { get; set; }

        [DisplayName("Autor")]
        public string Ahutor { get; set; }

        [DisplayName("Tags")]
        public virtual ICollection<TagEditViewModel> Tags { get; set; }

        [DisplayName("Es Público")]
        public bool IsPublic => !IsProvisional && PublishDate <= DateTime.Now;
    }

    public class PostDetailViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Subtítulo")]
        public string SubTitle { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Fecha Creación")]
        public DateTime PostDate { get; set; }

        [DisplayName("Contenido")]
      //  [DataType(DataType.MultilineText)]
        public string HtmlContent { get; set; }

        [DisplayName("Es Borrador")]
        public bool IsProvisional { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime PublishDate { get; set; }

        [DisplayName("Autor")]
        public string Ahutor { get; set; }

        [DisplayName("Tags")]
        public virtual ICollection<TagDetailViewModel> Tags { get; set; }

        [DisplayName("Es Público")]
        public bool IsPublic => !IsProvisional && PublishDate <= DateTime.Now;
    }


    public class PostDeleteViewModel
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Subtítulo")]
        public string SubTitle { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Url Clave")]
        public string SlugUrl { get; set; }

        [DisplayName("Fecha Creación")]
        public DateTime PostDate { get; set; }

        [DisplayName("Contenido")]
        public string HtmlContent { get; set; }

        [DisplayName("Es Borrador")]
        public bool IsProvisional { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime PublishDate { get; set; }

        [DisplayName("Autor")]
        public string Ahutor { get; set; }

        [DisplayName("Tags")]
        public virtual ICollection<TagDeleteViewModel> Tags { get; set; }

        [DisplayName("Es Público")]
        public bool IsPublic => !IsProvisional && PublishDate <= DateTime.Now;
    }
}