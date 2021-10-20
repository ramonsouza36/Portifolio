using System;

namespace Dominio.Entidades
{
    public class CompraViewModel

    {
        
        public int Id { get; set; }

        public DateTime dataVenda { get; set; }
        
        public float ValorTotal { get; set; }

        public string FormaPagamento { get; set; }

        public int Parcelas { get; set; } 

        public virtual ItensVendas ItensVendas { get; set; }

        public int CodigoVenda { get; set; }

        public string Item { get; set; }

        public int Quantidade { get; set; }

        public float ValorUnitario {get; set; }
        
        
        
        /*public Produto prod { get; set; }

        public Venda ven { get; set; }*/
    }
}