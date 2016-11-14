using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SistemaConsultorio.Infraestrutura.Repositorio;
using SistemaConsultorio.Servico;
using SistemaConsultorio.Dominio;

namespace WcfSistemaConsultorio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DentistaServico" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DentistaServico.svc or DentistaServico.svc.cs at the Solution Explorer and start debugging.
    public class DentistaServico : IDentistaServico
    {
        #region Atributos

        private DentistaRepositorio repositorio = new DentistaRepositorio();

        #endregion

        public void Cadastrar(Dentista d)
        {
            repositorio.Cadastrar(d);
        }

        public Dentista Buscar(int id)
        {
            return repositorio.Buscar(id);
        }

        public List<Dentista> BuscarTodos()
        {
            return repositorio.BuscarTodos();
        }

        public void Deletar(int id)
        {
            repositorio.Deletar(id);
        }

        public void Atualizar(Dentista dentistaNovo)
        {
            repositorio.Atualizar(dentistaNovo);
        }
    }
}
