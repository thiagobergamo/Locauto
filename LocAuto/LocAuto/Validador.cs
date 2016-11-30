using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocAuto
{
    public class Validador
    {
        public static String msgInteiro = "Este campo só permite números inteiros";
        public static String msgDecimal = "Este campo só permite números decimais";

        public static bool eInteiro(string texto)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(texto))
                {
                    decimal i = Convert.ToInt32(texto);
                }
        
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool eDecimal(string texto)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(texto))
                {
                    Convert.ToDecimal(texto);
                }
               
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
