using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace DaoMysql
{
    public class VistoriaDAO:IVistoriaDAO
    {
        public void inserir(Vistoria vistoria)
        {

        }
        public void atualizar(Vistoria vistoria)
        {

        }
        public Vistoria Retornar(int codigo)
        {
            Vistoria vistoria = new Vistoria();
            return vistoria;
        }
    }
}
