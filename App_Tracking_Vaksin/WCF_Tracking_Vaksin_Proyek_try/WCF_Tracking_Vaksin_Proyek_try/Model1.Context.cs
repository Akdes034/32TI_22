﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Tracking_Vaksin_Proyek_try
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class proyek_tryEntities : DbContext
    {
        public proyek_tryEntities()
            : base("name=proyek_tryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Penduduk> Penduduks { get; set; }
        public virtual DbSet<ReportInnVaksin> ReportInnVaksins { get; set; }
        public virtual DbSet<ReportUseVaksin> ReportUseVaksins { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vaksin> Vaksins { get; set; }
    }
}
