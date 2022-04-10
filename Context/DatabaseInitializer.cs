using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using InventoryItems.Models;

namespace InventoryItems.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var InventoryItem = new List<InventoryItemModel>()
            {
                new InventoryItemModel{Id=1, Name="Chips",Description="Onion Flevor",Price=10,Weight=10,MFGDate=DateTime.Parse("2000-06-15")},
                new InventoryItemModel{Id=2, Name="Parle",Description="Buiscuit",Price=20,Weight=25,MFGDate=DateTime.Parse("2001-05-16")},
                new InventoryItemModel{Id=3, Name="Mari",Description="Buiscuit",Price=30,Weight=20,MFGDate=DateTime.Parse("2002-08-17")},
                new InventoryItemModel{Id=4, Name="Coconut",Description="Coconut Buiscuit",Price=50,Weight=30,MFGDate=DateTime.Parse("2003-09-18")},
                new InventoryItemModel{Id=5, Name="Chips",Description="Tomato Flevor",Price=10,Weight=10,MFGDate=DateTime.Parse("2004-10-19")},
            };
            InventoryItem.ForEach(x => context.InventoryItems.Add(x));
            context.SaveChanges();
        }
    
    }
}