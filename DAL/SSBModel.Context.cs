﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SSB_DBEntities : DbContext
    {
        public SSB_DBEntities()
            : base("name=SSB_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_User> tbl_User { get; set; }
        public DbSet<tblArticle> tblArticles { get; set; }
        public DbSet<tblCustomer> tblCustomers { get; set; }
        public DbSet<tblPartyMaster> tblPartyMasters { get; set; }
        public DbSet<tblInvoice> tblInvoices { get; set; }
        public DbSet<tbl_InvoiceItemDetails> tbl_InvoiceItemDetails { get; set; }
    }
}