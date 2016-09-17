using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class VistoriaService
    {
        private IVistoriaDAO vistoriaDao;
        public VistoriaService() { }
        public VistoriaService(IVistoriaDAO vistoriaDao)
        {
            this.vistoriaDao = vistoriaDao;
        }
        public void inserir(Vistoria vistoria)
        {
            ValidarVistoria(vistoria);
            vistoriaDao.inserir(vistoria);
        }
        public void atualizar(Vistoria vistoria)
        {
            ValidarVistoria(vistoria);
            vistoriaDao.atualizar(vistoria);
        }
        public Vistoria Retornar(int codigo)
        {
            Vistoria vistoria = vistoriaDao.Retornar(codigo);
            return vistoria;
        }
        private void ValidarVistoria(Vistoria vistoria)
        {
            if (vistoria.CodigoUsuario == 0)
            {
                throw new ArgumentNullException("Vistoriador", "Campo obrigatório não preenchido");
            }
            if (vistoria.KmLoc == 0)
            {
                throw new ArgumentNullException("Km", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(vistoria.NivelCombLoc))
            {
                throw new ArgumentNullException("Nível Combustível", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(vistoria.LaudoLoc))
            {
                throw new ArgumentNullException("Laudo", "Campo obrigatório não preenchido");
            }
        }
    }
}
