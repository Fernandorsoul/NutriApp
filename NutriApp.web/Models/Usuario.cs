using Microsoft.IdentityModel.Tokens;
using NutriApp.web.Enums;
using System.ComponentModel.DataAnnotations;

namespace NutriApp.web.Models
{
    public class Usuario
    {
        [Required]
        [Display]
        public int UserId { get; set; }
        [Required]
        [Display]
        [MinLength(3, ErrorMessage="Minimo 3 caracteres")]
        [MaxLength(60, ErrorMessage = " maximo 60caracteres")]
        public string Nome { get; set; }
        [Required]
        [Display]
        [MinLength(11, ErrorMessage = "O CPF Deve Conter 11 Digitos")]
        [MaxLength(11, ErrorMessage = "O CPF Deve Conter 11 Digitos")]
        public string CPF { get; set; }
        [Display]
        [Required]
        public Genero Genero { get; set; }
        [Required (ErrorMessage="o preenchimento do Email é obrigatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage ="digite sua senha")]

        public string Senha { get; set;}

        public string Telefone { get; set; }

        public List<Dieta> Dieta { get; set; }
        
    
}
}
