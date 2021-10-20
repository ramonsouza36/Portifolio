using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public float ValorUnitario { get; set; }

        public int Quantidade { get; set; }
        
    }
}