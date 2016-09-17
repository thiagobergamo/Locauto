using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    interface IVistoriaDAO
    {
        void inserir(Vistoria vistoria);
        void atualizar(Vistoria vistoria);
        Vistoria Retornar(int codigo);
    }
}
