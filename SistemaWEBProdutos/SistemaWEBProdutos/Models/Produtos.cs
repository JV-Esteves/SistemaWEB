using System;
using System.Collections.Generic;

namespace SistemaWEBProdutos.Models
{
    public partial class Produtos
    {
        public int ProdCodigo { get; set; }
        public string ProdNome { get; set; }
        public decimal ProdPreco { get; set; }
        public int ProdQtde { get; set; }
    }
}
