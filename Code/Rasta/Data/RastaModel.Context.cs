﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rasta.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class rastaEntities : DbContext
    {
        public rastaEntities()
            : base("name=rastaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_accountpayable> tbl_accountpayable { get; set; }
        public DbSet<tbl_accountreceivable> tbl_accountreceivable { get; set; }
        public DbSet<tbl_apapprovers> tbl_apapprovers { get; set; }
        public DbSet<tbl_apdepartmentexpense> tbl_apdepartmentexpense { get; set; }
        public DbSet<tbl_apitexpense> tbl_apitexpense { get; set; }
        public DbSet<tbl_approjectexpense> tbl_approjectexpense { get; set; }
        public DbSet<tbl_bank> tbl_bank { get; set; }
        public DbSet<tbl_cbs> tbl_cbs { get; set; }
        public DbSet<tbl_costcode> tbl_costcode { get; set; }
        public DbSet<tbl_currency> tbl_currency { get; set; }
        public DbSet<tbl_currencyexchange> tbl_currencyexchange { get; set; }
        public DbSet<tbl_department> tbl_department { get; set; }
        public DbSet<tbl_discipline> tbl_discipline { get; set; }
        public DbSet<tbl_expensetype> tbl_expensetype { get; set; }
        public DbSet<tbl_icp> tbl_icp { get; set; }
        public DbSet<tbl_ipexopex> tbl_ipexopex { get; set; }
        public DbSet<tbl_itexpense> tbl_itexpense { get; set; }
        public DbSet<tbl_privilege> tbl_privilege { get; set; }
        public DbSet<tbl_project> tbl_project { get; set; }
        public DbSet<tbl_projecttype> tbl_projecttype { get; set; }
        public DbSet<tbl_rebill> tbl_rebill { get; set; }
        public DbSet<tbl_site> tbl_site { get; set; }
        public DbSet<tbl_supplier> tbl_supplier { get; set; }
        public DbSet<tbl_suppliertype> tbl_suppliertype { get; set; }
        public DbSet<tbl_suppliertypediscipline> tbl_suppliertypediscipline { get; set; }
        public DbSet<tbl_termdeposit> tbl_termdeposit { get; set; }
        public DbSet<tbl_userdiscipline> tbl_userdiscipline { get; set; }
        public DbSet<tbl_userprivilege> tbl_userprivilege { get; set; }
        public DbSet<tbl_users> tbl_users { get; set; }
        public DbSet<vw_accountpayable> vw_accountpayable { get; set; }
        public DbSet<vw_accountreceivable> vw_accountreceivable { get; set; }
        public DbSet<vw_bank> vw_bank { get; set; }
    }
}
