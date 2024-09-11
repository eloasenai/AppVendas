namespace AppvVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string ProdutoName { get; set; }
        public double Valor { get; set; }
        public double QtadeEstoque { get; set; }
        public bool CadastroAtivo { get; set; }


        /*chave Estrangeira*/
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
