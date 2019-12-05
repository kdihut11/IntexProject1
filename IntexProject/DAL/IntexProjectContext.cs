using IntexProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntexProject.DAL
{
    public class IntexProjectContext : DbContext
    {
        public IntexProjectContext() : base("IntexProjectContext")
        {

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Compound> Compound { get; set; }
        public DbSet<CompoundSample> CompoundSample { get; set; }
        public DbSet<Cost> Cost { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDiscount> InvoiceDiscount { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<PaymentInfo> PaymentInfo { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<SampleTests> SampleTests { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }
    }
}