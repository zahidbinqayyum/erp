﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWithSubmit.Db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERPEntities : DbContext
    {
        public ERPEntities()
            : base("name=ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusinessPartner> BusinessPartners { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<state> states { get; set; }
    }
}
