using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class TipoVeiculo
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string ArCondicionado { get; set; }
        public string VidroEletrico { get; set; }
        public string TravaEletrica { get; set; }
        public string Portas { get; set; }
        public string Abs { get; set; }
        public string AirBag { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
