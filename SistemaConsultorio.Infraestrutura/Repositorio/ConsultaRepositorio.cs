using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorio.Dominio;
using SistemaConsultorio.Infraestrutura.Contexto;

namespace SistemaConsultorio.Infraestrutura.Repositorio
{
    public class ConsultaRepositorio
    {
        public void Cadastrar(Consulta c)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                ctx.Consultas.Add(c);
                ctx.SaveChanges();
            }
        }

        public Consulta Buscar(int id)
        {
            Consulta c = new Consulta();
            using (var ctx = new SistemaConsultorioContexto())
            {
                c = ctx.Consultas.Find(id);
            }
            return c;
        }

        public IQueryable<Consulta> Buscar(Dentista dentista)
        {
            var ctx = new SistemaConsultorioContexto();
            Paciente p = new Paciente();
            var Consultas = ctx.Consultas.Where(c => c.IdDentista == dentista.Id);

            return Consultas;
        }

        public List<Consulta> Buscar(Dentista dentista, DateTime data)
        {
            var ctx = new SistemaConsultorioContexto();
            List<Consulta> Consultas = new List<Consulta>();
            var queryConsultas = ctx.Consultas.Where(c => c.IdDentista == dentista.Id);
            foreach(var consulta in queryConsultas)
            {
                if (consulta.Data == data)
                {
                    Consultas.Add(consulta);
                }
            }

            return Consultas;
        }

        public void Deletar(int id)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                Consulta c = ctx.Consultas.Find(id);
                ctx.Consultas.Remove(c);
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Consulta consultaNova)
        {
            using(var ctx = new SistemaConsultorioContexto())
            {
                Consulta consultaAntiga = ctx.Consultas.Find(consultaNova.IdConsulta);
                consultaAntiga.IdPaciente = consultaNova.IdPaciente;
                consultaAntiga.IdDentista = consultaNova.IdDentista;
                consultaAntiga.HoraMarcada = consultaNova.HoraMarcada;
                consultaAntiga.HoraInicio = consultaNova.HoraInicio;
                consultaAntiga.HoraFim = consultaNova.HoraFim;
                consultaAntiga.Data = consultaNova.Data;
                consultaAntiga.Observacao = consultaNova.Observacao;
                consultaAntiga.Status = consultaNova.Status;
                ctx.SaveChanges();
            }
        }
    }
}