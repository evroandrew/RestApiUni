﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestDatabaseEntityEntities : DbContext
    {
        public TestDatabaseEntityEntities()
            : base("name=TestDatabaseEntityEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbAudience> tbAudiences { get; set; }
        public virtual DbSet<tbAudLect> tbAudLects { get; set; }
        public virtual DbSet<tbDepartment> tbDepartments { get; set; }
        public virtual DbSet<tbGroup> tbGroups { get; set; }
        public virtual DbSet<tbLection> tbLections { get; set; }
        public virtual DbSet<tbMark> tbMarks { get; set; }
        public virtual DbSet<tbPhone> tbPhones { get; set; }
        public virtual DbSet<tbSpeciality> tbSpecialities { get; set; }
        public virtual DbSet<tbStudent> tbStudents { get; set; }
        public virtual DbSet<tbSubject> tbSubjects { get; set; }
        public virtual DbSet<tbTeacher> tbTeachers { get; set; }
        public virtual DbSet<tbTeachSubj> tbTeachSubjs { get; set; }
    }
}
