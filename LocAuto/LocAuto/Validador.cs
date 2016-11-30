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
        public static bool inteiro(string texto)
        {
            try
            {
                int i = Convert.ToInt32(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
