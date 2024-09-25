using System.ComponentModel.DataAnnotations;

namespace AppvVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo não pode ser vazio")]
        [MaxLength(100, ErrorMessage = "O campo deve ter , no maximo, 100 caracteres! ")]
        [MinLength(3, ErrorMessage = "O campo deve ter no ,mínimo ,3 caracteres!")]
        public string ProdutoName { get; set; }
        [Required(ErrorMessage = "O campo não pode ser vazio !")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do produto deve ser positivo !")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo não pode ser vazio !")]
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser positivo !")]
        [Display(Name = "Estoque atual?")]
        public double QtadeEstoque { get; set; }
        [Display(Name = "Ativo?")]
        public bool? CadastroAtivo { get; set; } = true;
        [Display(Name = "categoria")]

        /*chave Estrangeira*/
        [Required(ErrorMessage = "Por favor, selcione uma categoria!")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
