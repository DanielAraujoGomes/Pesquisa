﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationSistemaPesquisaFinal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEV_PESQUISA_SATISFACAOEntities : DbContext
    {
        public DEV_PESQUISA_SATISFACAOEntities()
            : base("name=DEV_PESQUISA_SATISFACAOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_Alternativas> TB_Alternativas { get; set; }
        public virtual DbSet<TB_Participantes> TB_Participantes { get; set; }
        public virtual DbSet<TB_Pesquisa> TB_Pesquisa { get; set; }
        public virtual DbSet<TB_Questoes> TB_Questoes { get; set; }
        public virtual DbSet<TB_Respostas> TB_Respostas { get; set; }
        public virtual DbSet<TB_TipoResposta> TB_TipoResposta { get; set; }
    }
}
