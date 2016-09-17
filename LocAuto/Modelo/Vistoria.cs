using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vistoria
    {
        public int Codigo { get; set; }
        public int CodigoLocacao { get; set; }
        public int CodigoUsuario { get; set; }
        public int KmLoc { get; set; }
        public int KmDev { get; set; }
        public string NivelCombLoc { get; set; }
        public string NivelCombDev { get; set; }
        public string LaudoLoc { get; set; }
        public string LaudoDev { get; set; }
    }
}
