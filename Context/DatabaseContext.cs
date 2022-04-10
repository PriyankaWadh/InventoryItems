using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventoryItems.Models;
using System.Data.Entity;

namespace InventoryItems.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("InventoryItemDB")
        {
        }
          public DbSet<InventoryItemModel> InventoryItems { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<p>();
        //}
    
    }
}

    
