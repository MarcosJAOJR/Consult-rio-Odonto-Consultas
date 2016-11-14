using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorio.Dominio;
using SistemaConsultorio.Infraestrutura.Contexto;

namespace SistemaConsultorio.Infraestrutura.Repositorio
{
    public class PacienteRepositorio
    {
        public void Cadastrar(Paciente p)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                ctx.Pacientes.Add(p);
                ctx.SaveChanges();
            }
        }

        public Paciente Buscar(int id)
        {
            Paciente p = new Paciente();
            using (var ctx = new SistemaConsultorioContexto())
            {
                p = ctx.Pacientes.Find(id);
            }
            return p;
        }

        public List<Paciente> BuscarTodos()
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                var Pacientes = (from d in ctx.Pacientes
                                 select d).OrderBy(x => x.Nome).ToList();
                return Pacientes;
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                Paciente p = ctx.Pacientes.Find(id);
                ctx.Pacientes.Remove(p);
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Paciente pacienteNovo)
        {
            Paciente pacienteAntigo = new Paciente();
            using (var ctx = new SistemaConsultorioContexto())
            {
                pacienteAntigo = ctx.Pacientes.Find(pacienteNovo.Id);
                pacienteAntigo.Nome = pacienteNovo.Nome;
                pacienteAntigo.Telefone = pacienteNovo.Telefone;
                pacienteAntigo.Celular = pacienteNovo.Celular;
                pacienteAntigo.Nascimento = pacienteNovo.Nascimento;
                pacienteAntigo.CEP = pacienteNovo.CEP;
                pacienteAntigo.Email = pacienteNovo.Email;
                pacienteAntigo.Endereco = pacienteNovo.Endereco;
                pacienteAntigo.Complemento = pacienteNovo.Complemento;
                ctx.SaveChanges();
            }
        }
    }
}
