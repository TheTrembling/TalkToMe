﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TalkToMe
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TalkToMeEntities : DbContext
    {
        public TalkToMeEntities()
            : base("name=TalkToMeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Friendlist> Friendlist { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}