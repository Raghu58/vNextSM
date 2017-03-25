﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vNext.SM.Data
{

    public class vNextSMDbContext : DbContext
    {
//Test
        public vNextSMDbContext() : base("SMDatabaseConnection")
        {
        }

        public DbSet<UserManagement.SMUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        int a=10;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
