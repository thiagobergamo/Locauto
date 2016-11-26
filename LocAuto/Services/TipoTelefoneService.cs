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
        private void ValidarTipoTelefone(TipoTelefone tipoTelefone)
        {
            if (String.IsNullOrWhiteSpace(tipoTelefone.Descricao))
            {
                throw new ArgumentNullException("Descrição", "Campo obrigatório não preenchido");
            }

        }
        public void atualizar(TipoTelefone tipoTelefone)
        {
            ValidarTipoTelefone(tipoTelefone);
            tipoTelefoneDAO.atualizar(tipoTelefone);
        }
        public void apagar(int id)
        {
            tipoTelefoneDAO.apagar(id);
        }
        public TipoTelefone buscaPorId(int id)
        {
            return tipoTelefoneDAO.buscaPorId(id);
        }
        public List<TipoTelefone> buscaTodos()
        {
            return tipoTelefoneDAO.buscaTodos();
        }
    }
}
