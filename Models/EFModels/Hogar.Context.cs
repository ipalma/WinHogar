﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.EFModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HogarEntities : DbContext
    {
        public HogarEntities()
            : base("name=HogarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<IncomeType> IncomeType { get; set; }
        public virtual DbSet<Outgoings> Outgoings { get; set; }
        public virtual DbSet<OutgoingType> OutgoingType { get; set; }
        public virtual DbSet<PredefinedOutgoins> PredefinedOutgoins { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<TotalAmount> TotalAmount { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
    }
}
