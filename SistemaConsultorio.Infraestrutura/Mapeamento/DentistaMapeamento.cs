﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SistemaConsultorio.Dominio;

namespace SistemaConsultorio.Infraestrutura.Mapeamento
{
    class DentistaMapeamento : EntityTypeConfiguration<Dentista>
    {
        public DentistaMapeamento()
        {
            this.ToTable("Dentista");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_DENTISTA");
            this.Property(d => d.Nome).HasColumnName("NOME_DENTISTA");
            this.Property(d => d.Email).HasColumnName("EMAIL_DENTISTA");
            this.Property(d => d.Telefone).HasColumnName("TELEFONE_DENTISTA");
            this.Property(d => d.Celular).HasColumnName("CELULAR_DENTISTA");
            this.Property(d => d.CRO).HasColumnName("CRO");
        }
    }
}
