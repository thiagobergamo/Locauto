using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class OpcionalService
    {
        private IOpcionalDAO opcionalDao;
        public OpcionalService() { }
        public OpcionalService(IOpcionalDAO opcionalDao)
        {
            this.opcionalDao = opcionalDao;
        }
        public void inserir(Opcional opcional)
        {
            ValidarOpcional(opcional);
            opcionalDao.inserir(opcional);
        }
        private void ValidarOpcional(Opcional opcional)
        {
            if (String.IsNullOrEmpty(opcional.Descricao))
            {
                throw new ArgumentNullException("Descrição", "Campo obrigatório não preenchido");
            }
            if (opcional.Valor == 0)
            {
                throw new ArgumentNullException("Valor", "Campo obrigatório não preenchido");
            }
        }
    }
}
