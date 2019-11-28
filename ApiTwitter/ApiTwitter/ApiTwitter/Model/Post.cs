using System;
using System.ComponentModel.DataAnnotations;

namespace ApiTwitter.Model
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [StringLength(280, MinimumLength = 3)]
        [Required]
        public string TextPost { get; set; }

        public string UrlPhoto { get; set; }

        public string UrlVideo { get; set; }

        public int? Like { get; set; }

        public bool IsComment { get; set; }

        public int IdPost { get; set; }

        public virtual User Users { get; set; }

        public virtual Post Posts { get; set; }
    }
}
