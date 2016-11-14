using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SistemaConsultorio.Servico;
using SistemaConsultorio.Infraestrutura.Repositorio;
using SistemaConsultorio.Dominio;

namespace WcfSistemaConsultorio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ConsultaServico" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ConsultaServico.svc or ConsultaServico.svc.cs at the Solution Explorer and start debugging.
    public class ConsultaServico : IConsultaServico
    {
        #region Atributos

        private ConsultaRepositorio repositorio = new ConsultaRepositorio();

        #endregion

        public void Cadastrar(Consulta c)
        {
            repositorio.Cadastrar(c);
        }

        public Consulta Buscar(int id)
        {
            return repositorio.Buscar(id);
        }

        public IQueryable<Consulta> Buscar(Dentista dentista)
        {
            return repositorio.Buscar(dentista);
        }

        public List<Consulta> Buscar (Dentista dentista, DateTime data)
        {
            return repositorio.Buscar(dentista, data);
        }

        public void Deletar(int id)
        {
            repositorio.Deletar(id);
        }

        public void Atualizar(Consulta consultaNova)
        {
            repositorio.Atualizar(consultaNova);
        }
    }
}
