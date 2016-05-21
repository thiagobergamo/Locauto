using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocAuto
{
    class Locacao
    {
        public int Codigo { get; set; }
        public string DataLocacao { get; set; }
        public string DataPrevDevolucao { get; set; }
        public string DataDevolucao { get; set; }
        public string DormaPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Pago { get; set; }
        public decimal ValorCaucao { get; set; }
    }
}
