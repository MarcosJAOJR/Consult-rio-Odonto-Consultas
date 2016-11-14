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
    public class PacienteServico : IPacienteServico
    {
        #region Atributos

        private PacienteRepositorio repositorio = new PacienteRepositorio();

        #endregion

        public void Cadastrar(Paciente p)
        {
            repositorio.Cadastrar(p);
        }

        public Paciente Buscar(int id)
        {
            return repositorio.Buscar(id);
        }

        public List<Paciente> BuscarTodos()
        {
            return repositorio.BuscarTodos();
        }

        public void Deletar(int id)
        {
            repositorio.Deletar(id);
        }

        public void Atualizar(Paciente pacienteNovo)
        {
            repositorio.Atualizar(pacienteNovo);
        }
    }
}
