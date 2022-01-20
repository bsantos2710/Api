using System.ComponentModel.DataAnnotations;

namespace ApiYouTube.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este Campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este Campo é deve conter de 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo é deve conter no minimo 3 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Este Campo é deve conter no maximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria invalida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }  
    }
}
