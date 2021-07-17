namespace Dominio.Entidades
{
    public class ItensVendas
    {
        public int Id { get; set; }

        public int CodigoVenda { get; set; }

        public string Item { get; set; }

        public int Quantidade { get; set; }

        public float ValorUnitario {get; set; }

        public virtual Produto produto { get; set; }

        public virtual Venda venda { get; set; } 
    }
}