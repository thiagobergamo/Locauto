﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Veiculo
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Observacao { get; set; }
        public string Cor { get; set; }
        public int codigoTipoVeiculo { get; set; }
        public int codigoSituacaoVeiculo { get; set; }
    }
}
