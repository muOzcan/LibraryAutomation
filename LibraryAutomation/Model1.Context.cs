﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryAutomation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryAutomationEntities : DbContext
    {
        public LibraryAutomationEntities()
            : base("name=LibraryAutomationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<Regist> Regist { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
