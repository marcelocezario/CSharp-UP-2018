using System.Collections.Generic;

namespace Modelos
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public string Nome { get; set; }

        public string UnidadeMedida { get; set; }

        public double QtdeEstoque { get; set; }

        public double CustoTotalEstoque { get; set; }

        public ComposicaoProduto ComposicaoProduto { get; set; }
    }
}
