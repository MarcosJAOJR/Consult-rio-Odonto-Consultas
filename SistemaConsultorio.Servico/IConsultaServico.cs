using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SistemaConsultorio.Dominio;

namespace SistemaConsultorio.Servico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IConsultaServico" in both code and config file together.
    [ServiceContract]
    public interface IConsultaServico
    {
        [OperationContract]
        void Cadastrar(Consulta c);

        [OperationContract(Name = "BuscarPorId")]
        Consulta Buscar(int id);

        [OperationContract(Name = "BuscarPorDentista")]
        IQueryable<Consulta> Buscar(Dentista dentista);

        [OperationContract(Name = "BuscarPorDentistaData")]
        List<Consulta> Buscar(Dentista dentista, DateTime data);

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Atualizar(Consulta consultaNova);
        

    }
}
