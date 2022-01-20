using System.ComponentModel.DataAnnotations;

namespace ApiYouTube.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage = "Este Campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este Campo é deve conter de 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo é deve conter no minimo 3 caracteres")]
        public string Title { get; set; }   
    }
}
