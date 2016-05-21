using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    public class TipoTelefoneDAO
    {
        public void inserir(TipoTelefone tipoTelefone)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            conn.Open();
        }
             
   
    }
}
