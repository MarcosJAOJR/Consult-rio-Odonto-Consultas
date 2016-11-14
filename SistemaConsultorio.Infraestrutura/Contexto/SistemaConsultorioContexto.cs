using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorio.Dominio;
using SistemaConsultorio.Infraestrutura.Mapeamento;

namespace SistemaConsultorio.Infraestrutura.Contexto
{
    class SistemaConsultorioContexto : DbContext
    {
        public SistemaConsultorioContexto() : base(/*"Server=RECEPÇÃO-PC\\SQLCONSULTORIO;Database=Consultorio_DB;Trusted_Connection=True;"*/"Server=PC-MARCOSJOSÉ\\SQLEXPRESS;Database=Consultorio_DB;Trusted_Connection=True;"/*"Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\95741\\Documents\\Teste_BD.mdf;Integrated Security=True;Connect Timeout=30"*/) { }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaConsultorioContexto>(null);

            modelBuilder.Configurations.Add(new ConsultaMapeamento());
            modelBuilder.Configurations.Add(new DentistaMapeamento());
            modelBuilder.Configurations.Add(new PacienteMapeamento());

            base.OnModelCreating(modelBuilder);
        }
    }
}
