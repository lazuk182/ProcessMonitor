﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessMonitor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MonitorEntities : DbContext
    {
        public MonitorEntities()
            : base("name=MonitorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CorreoNotificador> CorreoNotificador { get; set; }
        public virtual DbSet<CorreosDestinatarios> CorreosDestinatarios { get; set; }
        public virtual DbSet<NotificacionesEnviadas> NotificacionesEnviadas { get; set; }
        public virtual DbSet<Procesos> Procesos { get; set; }
    }
}