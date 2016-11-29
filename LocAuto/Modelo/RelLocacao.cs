using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RelLocacao
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string DataLocacao { get; set; }
        public string DataPrevDevolucao { get; set; }
        public string Veiculo { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
