﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailSender
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mailsEntities3 : DbContext
    {
        public mailsEntities3()
            : base("name=mailsEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mail_types> mail_types { get; set; }
        public virtual DbSet<mails> mails { get; set; }
        public virtual DbSet<recievers> recievers { get; set; }
        public virtual DbSet<senders> senders { get; set; }
    }
}