using System.ComponentModel.DataAnnotations;

namespace AppvVendas.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }

        [Display(Name = "descrição")]
        [Required(ErrorMessage = "O Campo é Obrigatorio")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter, no maximo, 100 caracteres!")]
        public string CategoriaName { get; set; }
    }
}
