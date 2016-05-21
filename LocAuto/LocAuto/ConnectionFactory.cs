using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient


namespace LocAuto
{
    class ConnectionFactory
    {
        public MySqlConnection ObterConexao()
        {
            String str = @"server=localhost;database=locauto;userid=thiago;password=senha;";
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }
}
