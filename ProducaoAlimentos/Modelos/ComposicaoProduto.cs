namespace Modelos
{
    public class ComposicaoProduto
    {
        public int ComposicaoProdutoID { get; set; }

        public int InsumoID { get; set; }

        public Insumo Insumo { get; set; }

        public double Qtde { get; set; }
    } 
}
