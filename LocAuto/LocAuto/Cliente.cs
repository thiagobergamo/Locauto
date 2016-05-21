using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocAuto
{
    public abstract class Cliente 
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public string LoginWeb { get; set; }
        public string SenhaWeb { get; set; }
        public string Cnh { get; set; }
        public string ValidadeCnh { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
