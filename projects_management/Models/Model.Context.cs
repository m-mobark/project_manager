﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projects_management.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<pm_feedback> pm_feedback { get; set; }
        public virtual DbSet<pm_personSkill> pm_personSkill { get; set; }
        public virtual DbSet<pm_project> pm_project { get; set; }
        public virtual DbSet<pm_projectComments> pm_projectComments { get; set; }
        public virtual DbSet<pm_projectTeam> pm_projectTeam { get; set; }
        public virtual DbSet<pm_Role> pm_Role { get; set; }
        public virtual DbSet<pm_User> pm_User { get; set; }
    }
}
