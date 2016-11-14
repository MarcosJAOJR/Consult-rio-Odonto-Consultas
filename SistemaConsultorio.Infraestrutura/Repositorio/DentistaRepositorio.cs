using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorio.Dominio;
using SistemaConsultorio.Infraestrutura.Contexto;

namespace SistemaConsultorio.Infraestrutura.Repositorio
{
    public class DentistaRepositorio
    {
        public void Cadastrar(Dentista d)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                ctx.Dentistas.Add(d);
                ctx.SaveChanges();
            }
        }

        public Dentista Buscar(int id)
        {
            Dentista d = new Dentista();
            using (var ctx = new SistemaConsultorioContexto())
            {
                d = ctx.Dentistas.Find(id);
            }
            return d;
        }

        public List<Dentista> BuscarTodos()
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                var Dentistas = (from d in ctx.Dentistas
                                 select d).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                Dentista d = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(d);
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Dentista dentistaNovo)
        {
            using (var ctx = new SistemaConsultorioContexto())
            {
                Dentista dentistaAntigo = ctx.Dentistas.Find(dentistaNovo.Id);
                dentistaAntigo.Nome = dentistaNovo.Nome;
                dentistaAntigo.Telefone = dentistaNovo.Telefone;
                dentistaAntigo.Celular = dentistaNovo.Celular;
                dentistaAntigo.CRO = dentistaNovo.CRO;
                dentistaAntigo.Email = dentistaNovo.Email;
                ctx.SaveChanges();
            }
        }
    }
}