﻿using IGL.Core.Entities.Inventory;
using IGL.Core.Entities.Master;
using IGL.Core.Entities.Organization;
using IGL.Core.Entities.Transaction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IGL.Core.Entities.CoreContext
{
    public class IGLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-SF1G3N8\\VIPRAIT; Database= IGLDevelopment; User Id=sa;Password = vi@pra91");
        }

        public DbSet<UnitMaster> UnitMasters { get; set; }
        public DbSet<CustomerMaster> CustomerMasters { get; set; }
        public DbSet<MaterialMaster> MaterialMasters { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<MaterialTransction> MaterialTransctions { get; set; }
        public DbSet<TransactionItems> TransactionItems { get; set; }
        public DbSet<VendorMaster> VendorMasters { get; set; }
        public DbSet<RiserMaster> RiserMasters { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<POItem> POItems { get; set; }
    }
}
