﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_School
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SQL_For_Today_SessionEntities2 : DbContext
    {
        public SQL_For_Today_SessionEntities2()
            : base("name=SQL_For_Today_SessionEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<Student_login> Student_login { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<Teacher_login> Teacher_login { get; set; }
    }
}
