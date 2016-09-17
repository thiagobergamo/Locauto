using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Locacao
    {
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoVeiculo { get; set; }
        public string DataLocacao { get; set; }
        public string DataPrevDevolucao { get; set; }
        public string DataDevolucao { get; set; }
        public string FormaPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorOpc { get; set; }
        public int MyProperty { get; set; }
        public string Pago { get; set; }
        public decimal ValorCaucao { get; set; }
    }
}
