﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnyStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnyStoreEntities1 : DbContext
    {
        public AnyStoreEntities1()
            : base("name=AnyStoreEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_categories> tbl_categories { get; set; }
        public virtual DbSet<tbl_dea_cust> tbl_dea_cust { get; set; }
        public virtual DbSet<tbl_products> tbl_products { get; set; }
        public virtual DbSet<tbl_transaction_detail> tbl_transaction_detail { get; set; }
        public virtual DbSet<tbl_transactions> tbl_transactions { get; set; }
        public virtual DbSet<tbl_users> tbl_users { get; set; }
    }
}