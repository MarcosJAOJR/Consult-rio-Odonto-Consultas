using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SistemaConsultorio.Dominio;

namespace SistemaConsultorio.Servico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPacienteServico" in both code and config file together.
    [ServiceContract]
    public interface IPacienteServico
    {
        [OperationContract]
        void Cadastrar(Paciente p);

        [OperationContract]
        Paciente Buscar(int id);

        [OperationContract]
        List<Paciente> BuscarTodos();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Atualizar(Paciente pacienteNovo);

    }
}
