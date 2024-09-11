namespace AppvVendas.Models
{
    public class ItemDaVenda
    {
        /*Relacionamento com a tabela de vendas */
        public Guid ItemDaVendaId { get; set; }
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        /*Relacionamento com a tabela de vendas */
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public double QtdadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }

    }
}
