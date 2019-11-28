using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiTwitter.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Nome")]
        [StringLength(250, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; }

        [Display(Name = "Celular")]
        [StringLength(250)]
        public string CellPhone { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "NickName")]
        [StringLength(250, MinimumLength = 3)]
        [Required]
        public string NickName { get; set; }

        [Display(Name = "Bio")]
        [StringLength(160)]
        public string Bio { get; set; }

        public string UrlPhoto { get; set; }

        public string ReseToken { get; set; }

        public string Token { get; set; }

        public DateTime DateCreate { get; set; }
    }
}
