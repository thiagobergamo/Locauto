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
        private ITipoTelefoneDAO tipoTelefoneDao;
        public TipoTelefoneService() { }
        public TipoTelefoneService(ITipoTelefoneDAO tipoTelefoneDAO)
        {
            this.tipoTelefoneDao = tipoTelefoneDAO;
        }
        public void inserir (TipoTelefone tipoTelefone)
        {
            ValidarTipoTelefone(tipoTelefone);
            tipoTelefoneDao.inserir(tipoTelefone);
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
            tipoTelefoneDao.atualizar(tipoTelefone);
        }
        public void apagar(int id)
        {
            tipoTelefoneDao.apagar(id);
        }
        public TipoTelefone buscaPorId(int id)
        {
            return tipoTelefoneDao.buscaPorId(id);
        }
        public List<TipoTelefone> buscaTodos()
        {
            return tipoTelefoneDao.buscaTodos();
        }
    }
}
