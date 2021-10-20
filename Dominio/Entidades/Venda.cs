using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Venda
    {
        public int Id { get; set; }

        public DateTime dataVenda { get; set; }
        
        public float ValorTotal { get; set; }

        public string FormaPagamento { get; set; }

        public int Parcelas { get; set; }       
    }
}