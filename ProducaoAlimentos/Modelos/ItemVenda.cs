using System;

namespace Modelos
{
    public class ItemVenda
    {
        public int ItemVendaID { get; set; }

        public Produto Produto { get; set; }

        public double Qtde { get; set; }

        public DateTime DataAdicao { get; set; }

        public double ValorVenda { get; set; }

        public double CustoVenda { get; set; }
    }
}
