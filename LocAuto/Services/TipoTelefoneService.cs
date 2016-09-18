using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class TipoTelefoneService
    {
        private ITipoTelefoneDAO tipoTelefoneDAO;
        public TipoTelefoneService() { }
        public TipoTelefoneService(ITipoTelefoneDAO tipoTelefoneDAO)
        {
            this.tipoTelefoneDAO = tipoTelefoneDAO;
        }
        public void inserir (TipoTelefone tipoTelefone)
        {
            ValidarTipoTelefone(tipoTelefone);
            tipoTelefoneDAO.inserir(tipoTelefone);
        }
        private void ValidarTipoTelefone(TipoTelefoneService tipoTelefone)
        {
            if (String.IsNullOrWhiteSpace(tipoTelefone.Tipo))
            {
                throw new ArgumentNullException("Código", "Campo obrigatório não preenchido");
            }

        }

    }
}
